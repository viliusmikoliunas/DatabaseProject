namespace DatabaseProject
{
    partial class ReviewOrderedForm
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
            this.orderedGrid = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderedGrid
            // 
            this.orderedGrid.AllowUserToAddRows = false;
            this.orderedGrid.AllowUserToDeleteRows = false;
            this.orderedGrid.AllowUserToResizeColumns = false;
            this.orderedGrid.AllowUserToResizeRows = false;
            this.orderedGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orderedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderedGrid.Location = new System.Drawing.Point(12, 25);
            this.orderedGrid.MultiSelect = false;
            this.orderedGrid.Name = "orderedGrid";
            this.orderedGrid.ReadOnly = true;
            this.orderedGrid.RowHeadersVisible = false;
            this.orderedGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderedGrid.Size = new System.Drawing.Size(506, 150);
            this.orderedGrid.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Testinis = ";
            // 
            // ReviewOrderedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.orderedGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReviewOrderedForm";
            this.Text = "ReviewOrderedForm";
            this.Load += new System.EventHandler(this.ReviewOrderedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderedGrid;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}