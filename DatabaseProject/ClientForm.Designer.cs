namespace DatabaseProject
{
    partial class ClientForm
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
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            this.ChooseFridgeButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.AvaivableFridgesLabel = new System.Windows.Forms.Label();
            this.CartLabel = new System.Windows.Forms.Label();
            this.RemoveFromCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.AllowUserToAddRows = false;
            this.WarehouseGridView.AllowUserToDeleteRows = false;
            this.WarehouseGridView.AllowUserToResizeColumns = false;
            this.WarehouseGridView.AllowUserToResizeRows = false;
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.WarehouseGridView.Location = new System.Drawing.Point(12, 26);
            this.WarehouseGridView.MultiSelect = false;
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.RowHeadersVisible = false;
            this.WarehouseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WarehouseGridView.Size = new System.Drawing.Size(313, 128);
            this.WarehouseGridView.TabIndex = 0;
            // 
            // ChooseFridgeButton
            // 
            this.ChooseFridgeButton.Location = new System.Drawing.Point(114, 160);
            this.ChooseFridgeButton.Name = "ChooseFridgeButton";
            this.ChooseFridgeButton.Size = new System.Drawing.Size(111, 23);
            this.ChooseFridgeButton.TabIndex = 1;
            this.ChooseFridgeButton.Text = "Order Selected";
            this.ChooseFridgeButton.UseVisualStyleBackColor = true;
            this.ChooseFridgeButton.Click += new System.EventHandler(this.ChooseFridgeButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(403, 160);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(79, 23);
            this.OrderButton.TabIndex = 2;
            this.OrderButton.Text = "Order Custom";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // CartGridView
            // 
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Location = new System.Drawing.Point(403, 26);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.Size = new System.Drawing.Size(306, 128);
            this.CartGridView.TabIndex = 3;
            // 
            // AvaivableFridgesLabel
            // 
            this.AvaivableFridgesLabel.AutoSize = true;
            this.AvaivableFridgesLabel.Location = new System.Drawing.Point(12, 9);
            this.AvaivableFridgesLabel.Name = "AvaivableFridgesLabel";
            this.AvaivableFridgesLabel.Size = new System.Drawing.Size(96, 13);
            this.AvaivableFridgesLabel.TabIndex = 4;
            this.AvaivableFridgesLabel.Text = "Avaivable for order";
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(400, 9);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(26, 13);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart";
            // 
            // RemoveFromCartButton
            // 
            this.RemoveFromCartButton.Location = new System.Drawing.Point(604, 160);
            this.RemoveFromCartButton.Name = "RemoveFromCartButton";
            this.RemoveFromCartButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveFromCartButton.TabIndex = 6;
            this.RemoveFromCartButton.Text = "Remove Selected";
            this.RemoveFromCartButton.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 191);
            this.Controls.Add(this.RemoveFromCartButton);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.AvaivableFridgesLabel);
            this.Controls.Add(this.CartGridView);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ChooseFridgeButton);
            this.Controls.Add(this.WarehouseGridView);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WarehouseGridView;
        private System.Windows.Forms.Button ChooseFridgeButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.Label AvaivableFridgesLabel;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Button RemoveFromCartButton;
    }
}