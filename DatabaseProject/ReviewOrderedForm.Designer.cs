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
            ((System.ComponentModel.ISupportInitialize)(this.orderedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderedGrid
            // 
            this.orderedGrid.AllowUserToAddRows = false;
            this.orderedGrid.AllowUserToDeleteRows = false;
            this.orderedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderedGrid.Location = new System.Drawing.Point(12, 12);
            this.orderedGrid.Name = "orderedGrid";
            this.orderedGrid.ReadOnly = true;
            this.orderedGrid.Size = new System.Drawing.Size(372, 150);
            this.orderedGrid.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(390, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 1;
            // 
            // ReviewOrderedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 175);
            this.Controls.Add(this.label);
            this.Controls.Add(this.orderedGrid);
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
    }
}