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
    public partial class AddVehicleForm : Form
    {
        private VehiclesForm _owner;
        public AddVehicleForm(VehiclesForm owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            OperationalYYBox.DataSource = Enumerable.Range(DateTime.Today.Year - 20, 21).Reverse().ToList();
            OperationalMMBox.DataSource = Enumerable.Range(1,12).ToList();
            OperationalDDBox.DataSource = Enumerable.Range(1, DateTime.DaysInMonth((int)OperationalYYBox.SelectedValue,(int)OperationalMMBox.SelectedValue)).ToList();

        }

        private void OperationalYYBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OperationalDDBox.DataSource = Enumerable.Range(1, DateTime.DaysInMonth((int)OperationalYYBox.SelectedValue, (int)OperationalMMBox.SelectedValue)).ToList();
            }
            catch (NullReferenceException) { }
        }

        private void OperationalMMBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OperationalDDBox.DataSource = Enumerable.Range(1, DateTime.DaysInMonth((int)OperationalYYBox.SelectedValue, (int)OperationalMMBox.SelectedValue)).ToList();
            }
            catch (NullReferenceException) { }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateOperations dop = new DateOperations();
            Vehicle newVehicle = new Vehicle
            {
                LicenceNumber = LicenceNumberBox.Text,
                Model = ModelBox.Text,
                OperationalFrom = 
                    dop.DateParsing(OperationalYYBox.Text,OperationalMMBox.Text,OperationalDDBox.Text),
                TrailerVolume = Decimal.Parse(TrailerVolumeBox.Text),
                MaximumLoad = Int32.Parse(MaximumLoadBox.Text)
            };
            using (var conn = new FridgeBussinessEntities2())
            {
                conn.Vehicle.Add(newVehicle);
                conn.SaveChanges();
            }
            Close();
        }

        private void AddVehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.VehiclesForm_Load(null, null);
        }
    }
}
