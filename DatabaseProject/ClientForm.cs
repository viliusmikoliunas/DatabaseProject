using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class ClientForm : Form
    {
        DataTable shoppingCartTable = new DataTable();
        DataTable warehouseTable = new DataTable();
        private string currentClient;

        private const int OrderToDeliverDayCount = 14;
        public ClientForm(string currentClient)
        {
            InitializeComponent();
            this.currentClient = currentClient;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ConnectToDB cdb = new ConnectToDB();
            warehouseTable = cdb.GetTableFromDB("Volume,Mass,ManufacturedOn,FridgeId", "Fridge", "where Customer is null");
            WarehouseGridView.DataSource = warehouseTable;
            WarehouseGridView.Columns[WarehouseGridView.ColumnCount-1].Visible = false;

            shoppingCartTable.Columns.AddRange(new []
            {
                new DataColumn("Volume",typeof(decimal)),
                new DataColumn("Mass",typeof(int)),
                new DataColumn("ManufacturedOn",typeof(DateTime)),
                new DataColumn("FridgeId",typeof(int)), 
            });
            CartGridView.DataSource = shoppingCartTable;
            CartGridView.Columns[CartGridView.ColumnCount - 1].Visible = false;
        }

        private void ChooseFridgeButton_Click(object sender, EventArgs e)
        {
            try
            {
                transferBetweenTables(WarehouseGridView, warehouseTable, shoppingCartTable);
            }
            catch (NullReferenceException) { }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                transferBetweenTables(CartGridView, shoppingCartTable, warehouseTable);
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is InvalidOperationException)
                {
                    if (CartGridView.Rows.Count > 1)
                    {
                        string currentFrVolume = CartGridView.CurrentRow.Cells["Volume"].Value.ToString();
                        shoppingCartTable.Rows.Remove(shoppingCartTable.AsEnumerable().First(r => r["Volume"].ToString() == currentFrVolume));
                    }
                    else shoppingCartTable.Clear();
                }
            }
        }

        private void transferBetweenTables(DataGridView tableView , DataTable test, DataTable table)
        {
            string currentFridgeId = tableView.CurrentRow.Cells["FridgeId"].Value.ToString();
            var row = test.AsEnumerable().Single(r => r["FridgeId"].ToString() == currentFridgeId);
            test.Rows.Remove(row);
            DataRow newRow = table.NewRow();
            using (var connenction = new FridgeBussinessEntities2())
            {
                Fridge current = connenction.Fridge.Single(f => f.FridgeID.ToString() == currentFridgeId);
                newRow["Volume"] = current.Volume;
                newRow["Mass"] = current.Mass;
                newRow["ManufacturedOn"] = current.ManufacturedOn;
                newRow["FridgeId"] = currentFridgeId;
                table.Rows.Add(newRow);
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            CustomOrderBox cust = new CustomOrderBox(this);
            cust.ShowDialog();
            if (CustomVolumeValue != null)
            {
                DataRow newRow = shoppingCartTable.NewRow();
                newRow["Volume"] = decimal.Parse(CustomVolumeValue);
                shoppingCartTable.Rows.Add(newRow);
                CustomVolumeValue = null;
            }
        }
        public string CustomVolumeValue { get;set;}

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if (CartGridView.Rows.Count > 0)
            {
                using (var connection = new FridgeBussinessEntities2())
                {
                    foreach (DataRow row in shoppingCartTable.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["FridgeId"].ToString()))
                        {
                            int frid = (int) row["FridgeId"];
                            Fridge toReplace = connection.Fridge.First(f => f.FridgeID == frid);
                            connection.Fridge.Remove(toReplace);
                            toReplace.Customer = currentClient;
                            toReplace.DeliverUntil = DateTime.Today.AddDays(OrderToDeliverDayCount);
                            connection.Fridge.Add(toReplace);
                        }
                        else
                        {
                            connection.Fridge.Add(new Fridge
                            {
                                Volume = (decimal) row["Volume"],
                                Customer = currentClient
                            });
                        }
                        connection.SaveChanges();
                    }
                }
                MessageBox.Show("Order successful");
                Close();
            }
            else MessageBox.Show("The cart is empty");
        }
    }
}
