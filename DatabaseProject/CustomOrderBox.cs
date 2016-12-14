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
    public partial class CustomOrderBox : Form
    {
        private ClientForm parentForm;
        public CustomOrderBox(ClientForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void CustomOrderBox_Load(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            parentForm.customVolumeValue = textBox1.Text;
            Close();
        }
    }
}
