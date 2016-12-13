namespace DatabaseProject
{
    partial class AddFridgeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MassBox = new System.Windows.Forms.TextBox();
            this.VolumeBox = new System.Windows.Forms.TextBox();
            this.CustomerBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DriverBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeliverYYBox = new System.Windows.Forms.ComboBox();
            this.DeliverMMBox = new System.Windows.Forms.ComboBox();
            this.DeliverDDBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ManufactureDateYYBox = new System.Windows.Forms.ComboBox();
            this.ManufactureDateMMBox = new System.Windows.Forms.ComboBox();
            this.ManufactureDateDDBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass(kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volume(dm3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturing date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer";
            // 
            // MassBox
            // 
            this.MassBox.Location = new System.Drawing.Point(4, 25);
            this.MassBox.Name = "MassBox";
            this.MassBox.Size = new System.Drawing.Size(149, 20);
            this.MassBox.TabIndex = 4;
            // 
            // VolumeBox
            // 
            this.VolumeBox.Location = new System.Drawing.Point(4, 64);
            this.VolumeBox.Name = "VolumeBox";
            this.VolumeBox.Size = new System.Drawing.Size(149, 20);
            this.VolumeBox.TabIndex = 5;
            // 
            // CustomerBox
            // 
            this.CustomerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerBox.FormattingEnabled = true;
            this.CustomerBox.Location = new System.Drawing.Point(199, 25);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(144, 21);
            this.CustomerBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DeliveringDriver";
            // 
            // DriverBox
            // 
            this.DriverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriverBox.FormattingEnabled = true;
            this.DriverBox.Location = new System.Drawing.Point(199, 63);
            this.DriverBox.Name = "DriverBox";
            this.DriverBox.Size = new System.Drawing.Size(144, 21);
            this.DriverBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DeliverUntil";
            // 
            // DeliverYYBox
            // 
            this.DeliverYYBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliverYYBox.FormattingEnabled = true;
            this.DeliverYYBox.Location = new System.Drawing.Point(199, 103);
            this.DeliverYYBox.Name = "DeliverYYBox";
            this.DeliverYYBox.Size = new System.Drawing.Size(58, 21);
            this.DeliverYYBox.TabIndex = 11;
            // 
            // DeliverMMBox
            // 
            this.DeliverMMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliverMMBox.FormattingEnabled = true;
            this.DeliverMMBox.Location = new System.Drawing.Point(263, 103);
            this.DeliverMMBox.Name = "DeliverMMBox";
            this.DeliverMMBox.Size = new System.Drawing.Size(38, 21);
            this.DeliverMMBox.TabIndex = 12;
            this.DeliverMMBox.SelectionChangeCommitted += new System.EventHandler(this.DeliverMMBox_SelectionChangeCommitted);
            // 
            // DeliverDDBox
            // 
            this.DeliverDDBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliverDDBox.FormattingEnabled = true;
            this.DeliverDDBox.Location = new System.Drawing.Point(307, 103);
            this.DeliverDDBox.Name = "DeliverDDBox";
            this.DeliverDDBox.Size = new System.Drawing.Size(36, 21);
            this.DeliverDDBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add New Fridge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManufactureDateYYBox
            // 
            this.ManufactureDateYYBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufactureDateYYBox.FormattingEnabled = true;
            this.ManufactureDateYYBox.Location = new System.Drawing.Point(4, 103);
            this.ManufactureDateYYBox.Name = "ManufactureDateYYBox";
            this.ManufactureDateYYBox.Size = new System.Drawing.Size(57, 21);
            this.ManufactureDateYYBox.TabIndex = 15;
            // 
            // ManufactureDateMMBox
            // 
            this.ManufactureDateMMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufactureDateMMBox.FormattingEnabled = true;
            this.ManufactureDateMMBox.Location = new System.Drawing.Point(66, 103);
            this.ManufactureDateMMBox.Name = "ManufactureDateMMBox";
            this.ManufactureDateMMBox.Size = new System.Drawing.Size(43, 21);
            this.ManufactureDateMMBox.TabIndex = 16;
            this.ManufactureDateMMBox.SelectionChangeCommitted += new System.EventHandler(this.ManufacturedDateMMBox_SelectionChangeCommitted);
            // 
            // ManufactureDateDDBox
            // 
            this.ManufactureDateDDBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufactureDateDDBox.FormattingEnabled = true;
            this.ManufactureDateDDBox.Location = new System.Drawing.Point(115, 103);
            this.ManufactureDateDDBox.Name = "ManufactureDateDDBox";
            this.ManufactureDateDDBox.Size = new System.Drawing.Size(38, 21);
            this.ManufactureDateDDBox.TabIndex = 17;
            // 
            // AddFridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 162);
            this.Controls.Add(this.ManufactureDateDDBox);
            this.Controls.Add(this.ManufactureDateMMBox);
            this.Controls.Add(this.ManufactureDateYYBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeliverDDBox);
            this.Controls.Add(this.DeliverMMBox);
            this.Controls.Add(this.DeliverYYBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DriverBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.VolumeBox);
            this.Controls.Add(this.MassBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFridgeForm";
            this.Text = "AddFridgeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFridgeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddFridgeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MassBox;
        private System.Windows.Forms.TextBox VolumeBox;
        private System.Windows.Forms.ComboBox CustomerBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DriverBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DeliverYYBox;
        private System.Windows.Forms.ComboBox DeliverMMBox;
        private System.Windows.Forms.ComboBox DeliverDDBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ManufactureDateYYBox;
        private System.Windows.Forms.ComboBox ManufactureDateMMBox;
        private System.Windows.Forms.ComboBox ManufactureDateDDBox;
    }
}