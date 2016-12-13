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
            this.deliveredButton = new System.Windows.Forms.Button();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unmarkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driverGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // driverGridView
            // 
            this.driverGridView.AllowUserToAddRows = false;
            this.driverGridView.AllowUserToDeleteRows = false;
            this.driverGridView.AllowUserToResizeColumns = false;
            this.driverGridView.AllowUserToResizeRows = false;
            this.driverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.driverGridView.Location = new System.Drawing.Point(12, 12);
            this.driverGridView.MultiSelect = false;
            this.driverGridView.Name = "driverGridView";
            this.driverGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverGridView.RowHeadersVisible = false;
            this.driverGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driverGridView.Size = new System.Drawing.Size(504, 150);
            this.driverGridView.TabIndex = 0;
            // 
            // deliveredButton
            // 
            this.deliveredButton.Location = new System.Drawing.Point(196, 168);
            this.deliveredButton.Name = "deliveredButton";
            this.deliveredButton.Size = new System.Drawing.Size(156, 23);
            this.deliveredButton.TabIndex = 1;
            this.deliveredButton.Text = "Mark as Delivered";
            this.deliveredButton.UseVisualStyleBackColor = true;
            this.deliveredButton.Click += new System.EventHandler(this.deliveredButton_Click);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(DatabaseProject.Driver);
            // 
            // unmarkButton
            // 
            this.unmarkButton.Location = new System.Drawing.Point(406, 168);
            this.unmarkButton.Name = "unmarkButton";
            this.unmarkButton.Size = new System.Drawing.Size(108, 23);
            this.unmarkButton.TabIndex = 2;
            this.unmarkButton.Text = "Unmark Delivery";
            this.unmarkButton.UseVisualStyleBackColor = true;
            this.unmarkButton.Click += new System.EventHandler(this.unmarkButton_Click);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 199);
            this.Controls.Add(this.unmarkButton);
            this.Controls.Add(this.deliveredButton);
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
        private System.Windows.Forms.Button deliveredButton;
        private System.Windows.Forms.Button unmarkButton;
    }
}