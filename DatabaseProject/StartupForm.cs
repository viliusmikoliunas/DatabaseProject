using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FridgeForm fridgeForm = new FridgeForm();
            fridgeForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm(ChooseDriverBox.Text);
            driverForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientForm cf = new ClientForm();
            cf.ShowDialog();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            using (var connection = new FridgeBussinessEntities2())
            {
                ChooseDriverBox.DataSource = connection.Driver.Select(d => d.FirstName+" "+d.LastName).ToList();
                ChooseClientBox.DataSource = connection.Customer.Select(d => d.CustomerName).ToList();
            }
        }
    }
}
