namespace DatabaseProject
{
    partial class VehiclesForm
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
            this.VehicleGridView = new System.Windows.Forms.DataGridView();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.EditVehicleButton = new System.Windows.Forms.Button();
            this.DeleteVehicleButton = new System.Windows.Forms.Button();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleGridView
            // 
            this.VehicleGridView.AllowUserToAddRows = false;
            this.VehicleGridView.AllowUserToDeleteRows = false;
            this.VehicleGridView.AllowUserToResizeColumns = false;
            this.VehicleGridView.AllowUserToResizeRows = false;
            this.VehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleGridView.Location = new System.Drawing.Point(12, 12);
            this.VehicleGridView.MultiSelect = false;
            this.VehicleGridView.Name = "VehicleGridView";
            this.VehicleGridView.ReadOnly = true;
            this.VehicleGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VehicleGridView.RowHeadersVisible = false;
            this.VehicleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehicleGridView.Size = new System.Drawing.Size(603, 150);
            this.VehicleGridView.TabIndex = 0;
            this.VehicleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehicleGridView_CellContentClick);
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(621, 12);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(97, 23);
            this.AddVehicleButton.TabIndex = 1;
            this.AddVehicleButton.Text = "Add Vehicle";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // EditVehicleButton
            // 
            this.EditVehicleButton.Location = new System.Drawing.Point(621, 41);
            this.EditVehicleButton.Name = "EditVehicleButton";
            this.EditVehicleButton.Size = new System.Drawing.Size(97, 23);
            this.EditVehicleButton.TabIndex = 2;
            this.EditVehicleButton.Text = "Edit Vehicle";
            this.EditVehicleButton.UseVisualStyleBackColor = true;
            this.EditVehicleButton.Click += new System.EventHandler(this.EditVehicleButton_Click);
            // 
            // DeleteVehicleButton
            // 
            this.DeleteVehicleButton.Location = new System.Drawing.Point(621, 70);
            this.DeleteVehicleButton.Name = "DeleteVehicleButton";
            this.DeleteVehicleButton.Size = new System.Drawing.Size(97, 23);
            this.DeleteVehicleButton.TabIndex = 3;
            this.DeleteVehicleButton.Text = "Delete Vehicle";
            this.DeleteVehicleButton.UseVisualStyleBackColor = true;
            this.DeleteVehicleButton.Click += new System.EventHandler(this.DeleteVehicleButton_Click);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(DatabaseProject.Vehicle);
            // 
            // VehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 172);
            this.Controls.Add(this.DeleteVehicleButton);
            this.Controls.Add(this.EditVehicleButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.VehicleGridView);
            this.Name = "VehiclesForm";
            this.Text = "VehiclesForm";
            this.Load += new System.EventHandler(this.VehiclesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.DataGridView VehicleGridView;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button EditVehicleButton;
        private System.Windows.Forms.Button DeleteVehicleButton;
    }
}