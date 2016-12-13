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
                insertNewRow(WarehouseGridView, shoppingCartTable);
            }
            catch (NullReferenceException) { }
        }

        private void RemoveFromCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                insertNewRow(CartGridView, warehouseTable);
            }
            catch (NullReferenceException) { }
        }

        private void insertNewRow(DataGridView tableView , DataTable table)
        {
            int currentFridgeId = (int)tableView.CurrentRow.Cells["FridgeId"].Value;
            tableView.Rows.Remove(tableView.CurrentRow);
            DataRow newRow = table.NewRow();
            using (var connenction = new FridgeBussinessEntities2())
            {
                Fridge current = connenction.Fridge.Single(f => f.FridgeID == currentFridgeId);
                newRow["Volume"] = current.Volume;
                newRow["Mass"] = current.Mass;
                newRow["ManufacturedOn"] = current.ManufacturedOn;
                newRow["FridgeId"] = currentFridgeId;
                table.Rows.Add(newRow);
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
