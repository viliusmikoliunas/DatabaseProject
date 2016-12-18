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
            ValidationClass validate = new ValidationClass();
            if (validate.ValidateVolume(textBox1.Text))
            {
                CorrectValue correct = new CorrectValue();
                parentForm.CustomVolumeValue = correct.CorrectVolume(textBox1.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Wrong volume");
                textBox1.Clear();
            }
        }
    }
}
