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
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ConnectToDB cdb = new ConnectToDB();
            DataTable warehouseTable = cdb.GetTableFromDB("Fridge", "Select Volume,Mass,ManufacturedOn,FridgeId from");
            WarehouseGridView.DataSource = warehouseTable;
            WarehouseGridView.Columns[WarehouseGridView.ColumnCount-1].Visible = false;
        }
    }
}
