namespace DatabaseProject
{
    partial class DriverForm
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
            this.components = new System.ComponentModel.Container();
            this.driverGridView = new System.Windows.Forms.DataGridView();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.driverGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // driverGridView
            // 
            this.driverGridView.AllowUserToAddRows = false;
            this.driverGridView.AllowUserToDeleteRows = false;
            this.driverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverGridView.Location = new System.Drawing.Point(12, 12);
            this.driverGridView.Name = "driverGridView";
            this.driverGridView.Size = new System.Drawing.Size(710, 150);
            this.driverGridView.TabIndex = 0;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(DatabaseProject.Driver);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 173);
            this.Controls.Add(this.driverGridView);
            this.Name = "DriverForm";
            this.Text = "DriverForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DriverForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DriverForm_FormClosed);
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.DataGridView driverGridView;
    }
}