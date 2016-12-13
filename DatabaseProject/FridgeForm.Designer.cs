namespace DatabaseProject
{
    partial class FridgeForm
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
            this.FridgeGridView = new System.Windows.Forms.DataGridView();
            this.fridgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddFridgeButton = new System.Windows.Forms.Button();
            this.EditFridgeButton = new System.Windows.Forms.Button();
            this.DeleteFridgeButton = new System.Windows.Forms.Button();
            this.fridgeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverUntilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FridgeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FridgeGridView
            // 
            this.FridgeGridView.AllowUserToAddRows = false;
            this.FridgeGridView.AllowUserToDeleteRows = false;
            this.FridgeGridView.AllowUserToResizeColumns = false;
            this.FridgeGridView.AllowUserToResizeRows = false;
            this.FridgeGridView.AutoGenerateColumns = false;
            this.FridgeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FridgeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fridgeIDDataGridViewTextBoxColumn,
            this.massDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.manufacturedOnDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.deliverUntilDataGridViewTextBoxColumn,
            this.deliveredAtDataGridViewTextBoxColumn});
            this.FridgeGridView.DataSource = this.fridgeBindingSource;
            this.FridgeGridView.Location = new System.Drawing.Point(0, 0);
            this.FridgeGridView.MultiSelect = false;
            this.FridgeGridView.Name = "FridgeGridView";
            this.FridgeGridView.ReadOnly = true;
            this.FridgeGridView.RowHeadersVisible = false;
            this.FridgeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FridgeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FridgeGridView.Size = new System.Drawing.Size(804, 237);
            this.FridgeGridView.TabIndex = 0;
            this.FridgeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FridgeGridView_CellContentClick);
            // 
            // fridgeBindingSource
            // 
            this.fridgeBindingSource.DataSource = typeof(DatabaseProject.Fridge);
            // 
            // AddFridgeButton
            // 
            this.AddFridgeButton.Location = new System.Drawing.Point(810, 12);
            this.AddFridgeButton.Name = "AddFridgeButton";
            this.AddFridgeButton.Size = new System.Drawing.Size(132, 23);
            this.AddFridgeButton.TabIndex = 1;
            this.AddFridgeButton.Text = "Add new fridge";
            this.AddFridgeButton.UseVisualStyleBackColor = true;
            this.AddFridgeButton.Click += new System.EventHandler(this.AddFridgeButton_Click);
            // 
            // EditFridgeButton
            // 
            this.EditFridgeButton.Location = new System.Drawing.Point(810, 41);
            this.EditFridgeButton.Name = "EditFridgeButton";
            this.EditFridgeButton.Size = new System.Drawing.Size(132, 25);
            this.EditFridgeButton.TabIndex = 2;
            this.EditFridgeButton.Text = "Edit fridge";
            this.EditFridgeButton.UseVisualStyleBackColor = true;
            this.EditFridgeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteFridgeButton
            // 
            this.DeleteFridgeButton.Location = new System.Drawing.Point(810, 72);
            this.DeleteFridgeButton.Name = "DeleteFridgeButton";
            this.DeleteFridgeButton.Size = new System.Drawing.Size(132, 23);
            this.DeleteFridgeButton.TabIndex = 3;
            this.DeleteFridgeButton.Text = "Delete fridge";
            this.DeleteFridgeButton.UseVisualStyleBackColor = true;
            this.DeleteFridgeButton.Click += new System.EventHandler(this.DeleteFridgeButton_Click);
            // 
            // fridgeIDDataGridViewTextBoxColumn
            // 
            this.fridgeIDDataGridViewTextBoxColumn.DataPropertyName = "FridgeID";
            this.fridgeIDDataGridViewTextBoxColumn.HeaderText = "FridgeID";
            this.fridgeIDDataGridViewTextBoxColumn.Name = "fridgeIDDataGridViewTextBoxColumn";
            this.fridgeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // massDataGridViewTextBoxColumn
            // 
            this.massDataGridViewTextBoxColumn.DataPropertyName = "Mass";
            this.massDataGridViewTextBoxColumn.HeaderText = "Mass";
            this.massDataGridViewTextBoxColumn.Name = "massDataGridViewTextBoxColumn";
            this.massDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturedOnDataGridViewTextBoxColumn
            // 
            this.manufacturedOnDataGridViewTextBoxColumn.DataPropertyName = "ManufacturedOn";
            this.manufacturedOnDataGridViewTextBoxColumn.HeaderText = "ManufacturedOn";
            this.manufacturedOnDataGridViewTextBoxColumn.Name = "manufacturedOnDataGridViewTextBoxColumn";
            this.manufacturedOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliverUntilDataGridViewTextBoxColumn
            // 
            this.deliverUntilDataGridViewTextBoxColumn.DataPropertyName = "DeliverUntil";
            this.deliverUntilDataGridViewTextBoxColumn.HeaderText = "DeliverUntil";
            this.deliverUntilDataGridViewTextBoxColumn.Name = "deliverUntilDataGridViewTextBoxColumn";
            this.deliverUntilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveredAtDataGridViewTextBoxColumn
            // 
            this.deliveredAtDataGridViewTextBoxColumn.DataPropertyName = "DeliveredAt";
            this.deliveredAtDataGridViewTextBoxColumn.HeaderText = "DeliveredAt";
            this.deliveredAtDataGridViewTextBoxColumn.Name = "deliveredAtDataGridViewTextBoxColumn";
            this.deliveredAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FridgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(950, 237);
            this.Controls.Add(this.DeleteFridgeButton);
            this.Controls.Add(this.EditFridgeButton);
            this.Controls.Add(this.AddFridgeButton);
            this.Controls.Add(this.FridgeGridView);
            this.MaximizeBox = false;
            this.Name = "FridgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.FridgeForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.FridgeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fridgeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FridgeGridView;
        private System.Windows.Forms.BindingSource fridgeBindingSource;
        private System.Windows.Forms.Button AddFridgeButton;
        private System.Windows.Forms.Button EditFridgeButton;
        private System.Windows.Forms.Button DeleteFridgeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fridgeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverUntilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredAtDataGridViewTextBoxColumn;
    }
}

