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
    public partial class DriverForm : Form
    {
        private DataTable driverTable;
        public DriverForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            DriverTable getTable = new DriverTable();
            driverTable = getTable.GenerateDataTableForDriver();
            driverTable = getTable.FillDataTable(driverTable);

            driverGridView.DataSource = driverTable;
        }

        private void DriverForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void DriverForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
