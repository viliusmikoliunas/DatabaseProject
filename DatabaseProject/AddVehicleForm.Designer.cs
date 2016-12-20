namespace DatabaseProject
{
    partial class AddVehicleForm
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
            this.LicenceNumberBox = new System.Windows.Forms.TextBox();
            this.LicenceNumberLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.OperationalLabel = new System.Windows.Forms.Label();
            this.OperationalYYBox = new System.Windows.Forms.ComboBox();
            this.OperationalDDBox = new System.Windows.Forms.ComboBox();
            this.OperationalMMBox = new System.Windows.Forms.ComboBox();
            this.TrailerVolumeLabel = new System.Windows.Forms.Label();
            this.TrailerVolumeBox = new System.Windows.Forms.TextBox();
            this.MaximumLoadLabel = new System.Windows.Forms.Label();
            this.MaximumLoadBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LicenceNumberBox
            // 
            this.LicenceNumberBox.Location = new System.Drawing.Point(12, 22);
            this.LicenceNumberBox.Name = "LicenceNumberBox";
            this.LicenceNumberBox.Size = new System.Drawing.Size(172, 20);
            this.LicenceNumberBox.TabIndex = 0;
            // 
            // LicenceNumberLabel
            // 
            this.LicenceNumberLabel.AutoSize = true;
            this.LicenceNumberLabel.Location = new System.Drawing.Point(12, 6);
            this.LicenceNumberLabel.Name = "LicenceNumberLabel";
            this.LicenceNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.LicenceNumberLabel.TabIndex = 1;
            this.LicenceNumberLabel.Text = "Licence Number";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(12, 45);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Model";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(12, 61);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(172, 20);
            this.ModelBox.TabIndex = 3;
            // 
            // OperationalLabel
            // 
            this.OperationalLabel.AutoSize = true;
            this.OperationalLabel.Location = new System.Drawing.Point(12, 84);
            this.OperationalLabel.Name = "OperationalLabel";
            this.OperationalLabel.Size = new System.Drawing.Size(87, 13);
            this.OperationalLabel.TabIndex = 4;
            this.OperationalLabel.Text = "Operational From";
            // 
            // OperationalYYBox
            // 
            this.OperationalYYBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationalYYBox.FormattingEnabled = true;
            this.OperationalYYBox.Location = new System.Drawing.Point(12, 100);
            this.OperationalYYBox.Name = "OperationalYYBox";
            this.OperationalYYBox.Size = new System.Drawing.Size(70, 21);
            this.OperationalYYBox.TabIndex = 5;
            this.OperationalYYBox.SelectedIndexChanged += new System.EventHandler(this.OperationalYYBox_SelectedIndexChanged);
            // 
            // OperationalDDBox
            // 
            this.OperationalDDBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationalDDBox.FormattingEnabled = true;
            this.OperationalDDBox.Location = new System.Drawing.Point(141, 100);
            this.OperationalDDBox.Name = "OperationalDDBox";
            this.OperationalDDBox.Size = new System.Drawing.Size(43, 21);
            this.OperationalDDBox.TabIndex = 6;
            // 
            // OperationalMMBox
            // 
            this.OperationalMMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperationalMMBox.FormattingEnabled = true;
            this.OperationalMMBox.Location = new System.Drawing.Point(88, 100);
            this.OperationalMMBox.Name = "OperationalMMBox";
            this.OperationalMMBox.Size = new System.Drawing.Size(47, 21);
            this.OperationalMMBox.TabIndex = 7;
            this.OperationalMMBox.SelectedIndexChanged += new System.EventHandler(this.OperationalMMBox_SelectedIndexChanged);
            // 
            // TrailerVolumeLabel
            // 
            this.TrailerVolumeLabel.AutoSize = true;
            this.TrailerVolumeLabel.Location = new System.Drawing.Point(12, 124);
            this.TrailerVolumeLabel.Name = "TrailerVolumeLabel";
            this.TrailerVolumeLabel.Size = new System.Drawing.Size(74, 13);
            this.TrailerVolumeLabel.TabIndex = 8;
            this.TrailerVolumeLabel.Text = "Trailer Volume";
            // 
            // TrailerVolumeBox
            // 
            this.TrailerVolumeBox.Location = new System.Drawing.Point(12, 140);
            this.TrailerVolumeBox.Name = "TrailerVolumeBox";
            this.TrailerVolumeBox.Size = new System.Drawing.Size(172, 20);
            this.TrailerVolumeBox.TabIndex = 9;
            // 
            // MaximumLoadLabel
            // 
            this.MaximumLoadLabel.AutoSize = true;
            this.MaximumLoadLabel.Location = new System.Drawing.Point(12, 163);
            this.MaximumLoadLabel.Name = "MaximumLoadLabel";
            this.MaximumLoadLabel.Size = new System.Drawing.Size(78, 13);
            this.MaximumLoadLabel.TabIndex = 10;
            this.MaximumLoadLabel.Text = "Maximum Load";
            // 
            // MaximumLoadBox
            // 
            this.MaximumLoadBox.Location = new System.Drawing.Point(12, 179);
            this.MaximumLoadBox.Name = "MaximumLoadBox";
            this.MaximumLoadBox.Size = new System.Drawing.Size(172, 20);
            this.MaximumLoadBox.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(50, 205);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Save Changes";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 236);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MaximumLoadBox);
            this.Controls.Add(this.MaximumLoadLabel);
            this.Controls.Add(this.TrailerVolumeBox);
            this.Controls.Add(this.TrailerVolumeLabel);
            this.Controls.Add(this.OperationalMMBox);
            this.Controls.Add(this.OperationalDDBox);
            this.Controls.Add(this.OperationalYYBox);
            this.Controls.Add(this.OperationalLabel);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.LicenceNumberLabel);
            this.Controls.Add(this.LicenceNumberBox);
            this.Name = "AddVehicleForm";
            this.Text = "Add Vehicle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddVehicleForm_FormClosing);
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LicenceNumberBox;
        private System.Windows.Forms.Label LicenceNumberLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Label OperationalLabel;
        private System.Windows.Forms.ComboBox OperationalYYBox;
        private System.Windows.Forms.ComboBox OperationalDDBox;
        private System.Windows.Forms.ComboBox OperationalMMBox;
        private System.Windows.Forms.Label TrailerVolumeLabel;
        private System.Windows.Forms.TextBox TrailerVolumeBox;
        private System.Windows.Forms.Label MaximumLoadLabel;
        private System.Windows.Forms.TextBox MaximumLoadBox;
        private System.Windows.Forms.Button AddButton;
    }
}