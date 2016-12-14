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
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ConnectToDB cdb = new ConnectToDB();
            warehouseTable = cdb.GetTableFromDB("Fridge", "Select Volume,Mass,ManufacturedOn,FridgeId from");
            WarehouseGridView.DataSource = warehouseTable;
            WarehouseGridView.Columns[WarehouseGridView.ColumnCount-1].Visible = false;

            shoppingCartTable.Columns.AddRange(new []
            {
                new DataColumn("Volume",typeof(decimal)),
                new DataColumn("Mass",typeof(int)),
                new DataColumn("ManufacturedOn",typeof(DateTime)),
                new DataColumn("FridgeId",typeof(int)), 
                //money maybe??   
            });
            CartGridView.DataSource = shoppingCartTable;
            CartGridView.Columns[CartGridView.ColumnCount - 1].Visible = false;
        }

        private void ChooseFridgeButton_Click(object sender, EventArgs e)
        {
            try
            {
                insertNewRow(WarehouseGridView, warehouseTable, shoppingCartTable);
            }
            catch (NullReferenceException) { }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                insertNewRow(CartGridView, shoppingCartTable, warehouseTable);
            }
            catch (NullReferenceException) { }
        }

        private void insertNewRow(DataGridView tableView , DataTable test, DataTable table)
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
            if (customVolumeValue != null)
            {
                DataRow newRow = shoppingCartTable.NewRow();
                newRow["Volume"] = Decimal.Parse(customVolumeValue);
                shoppingCartTable.Rows.Add(newRow);
            }
        }
        public string customVolumeValue { get;set;}

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
