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
        private readonly List<int> deliveredFridgesTodayIdList = new List<int>();
        private string driverFullName;
        public DriverForm(string currentDriver="")
        {
            InitializeComponent();
            driverFullName = currentDriver;
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            DriverTable getTable = new DriverTable();
            driverTable = getTable.GenerateDataTableForDriver(driverFullName);

            driverGridView.DataSource = driverTable;
        }

        private void DriverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (deliveredFridgesTodayIdList.Count > 0)
            {
                string line = "";
                using (var connection = new FridgeBussinessEntities2())
                {
                    foreach (int id in deliveredFridgesTodayIdList)
                    {
                        Fridge temp = new Fridge();
                        temp = connection.Fridge.Single(f => f.FridgeID == id);
                        line += "Klientas: " + temp.Customer + " | Saldytuvo nr: " + temp.FridgeID + "\n";
                    }
                }

                DialogResult result = MessageBox.Show("Pakeitimai:\n"+line+"Issaugoti?", "Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (var connection = new FridgeBussinessEntities2())
                    {
                        foreach (var fr in deliveredFridgesTodayIdList) connection.Fridge.Single(f => f.FridgeID == fr).DeliveredAt = DateTime.Today;
                        connection.SaveChanges();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void DriverForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void deliveredButton_Click(object sender, EventArgs e)
        {
            int currRowFrId = (int)driverGridView.CurrentRow.Cells[0].Value;
            if (string.IsNullOrEmpty(driverGridView.CurrentRow.Cells["Delivered"].Value as string))
            {
                deliveredFridgesTodayIdList.Add(currRowFrId);
                driverGridView.CurrentRow.Cells["Delivered"].Value = DateTime.Today;
            }
        }

        private void unmarkButton_Click(object sender, EventArgs e)
        {
            int currRowFrId = (int)driverGridView.CurrentRow.Cells[0].Value;
            if (!string.IsNullOrEmpty(driverGridView.CurrentRow.Cells["Delivered"].Value as string))
            {
                deliveredFridgesTodayIdList.Remove(currRowFrId);
                driverGridView.CurrentRow.Cells["Delivered"].Value = new DateTime();
            }

        }
    }
}