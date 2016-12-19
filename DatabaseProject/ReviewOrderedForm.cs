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
    public partial class ReviewOrderedForm : Form
    {
        private string currentClient;
        public ReviewOrderedForm(string currentClient)
        {
            InitializeComponent();
            this.currentClient = currentClient;
        }

        private void ReviewOrderedForm_Load(object sender, EventArgs e)
        {
            label.Text = currentClient;
            ConnectToDB connect = new ConnectToDB();
            //DataTable orderTable = connect.GetTableFromDB("*","Fridge", "where Customer=UAB Senukai");
            //orderedGrid.DataSource = orderTable;
        }
    }
}
