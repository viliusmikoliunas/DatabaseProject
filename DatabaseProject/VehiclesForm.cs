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
    public partial class VehiclesForm : Form
    {
        public VehiclesForm()
        {
            InitializeComponent();
        }

        private void VehicleGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void VehiclesForm_Load(object sender, EventArgs e)
        {
            ConnectToDB db = new ConnectToDB();
            DataTable table = db.GetTableFromDB("*","Vehicle");

            VehicleGridView.DataSource = table;
            //VehicleGridView.Columns.Add("Driver", "Driver");
            //using (var conn = new FridgeBussinessEntities2())
            //{
            //    foreach (DataRow row in table.Rows)
            //    {
                    //Driver dr = conn.Driver.Single(d => d.VehicleLicenceNumber == row["LicenceNumber"].ToString());
                    //row[drivers] = dr!=null ? dr.FirstName + " " + dr.LastName: "";
               // }
            //}
            
        }

        private void DeleteVehicleButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number = VehicleGridView.CurrentRow.Cells[0].Value.ToString();
                using (var con = new FridgeBussinessEntities2())
                {
                    con.Vehicle.Remove(con.Vehicle.FirstOrDefault(f => f.LicenceNumber == number));
                    con.SaveChanges();
                }
                VehiclesForm_Load(this, e);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicle = new AddVehicleForm(this);
            addVehicle.ShowDialog();
        }

        private void EditVehicleButton_Click(object sender, EventArgs e)
        {
            string number = VehicleGridView.CurrentRow.Cells[0].Value.ToString();
            //tbc
        }
    }
}
