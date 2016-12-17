using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class FridgeForm : Form
    {
        public FridgeForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ConnectToDB con = new ConnectToDB();
            DataTable fridgeTable = con.GetTableFromDB("*","Fridge");
            FridgeGridView.DataSource = fridgeTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddFridgeButton_Click(object sender, EventArgs e)
        {
            AddFridgeForm addFr = new AddFridgeForm(this);
            addFr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFridgeForm addFr = new AddFridgeForm(this,(int)FridgeGridView.CurrentRow.Cells[0].Value);
            addFr.ShowDialog();
        }

        private void FridgeForm_Enter(object sender, EventArgs e)
        {

        }

        private void DeleteFridgeButton_Click(object sender, EventArgs e)
        {
            int fridgeid = (int)FridgeGridView.CurrentRow.Cells[0].Value;
            using (var con = new FridgeBussinessEntities2())
            {
                con.Fridge.Remove(con.Fridge.FirstOrDefault(f => f.FridgeID == fridgeid));
                con.SaveChanges();
            }
            Form1_Load(this,e);
        }

        private void FridgeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
