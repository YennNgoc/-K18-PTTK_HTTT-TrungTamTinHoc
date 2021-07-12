namespace PTTK
{
    partial class TraCuuHoaDon
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
            this.data_HD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // data_HD
            // 
            this.data_HD.AllowUserToAddRows = false;
            this.data_HD.AllowUserToDeleteRows = false;
            this.data_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_HD.Location = new System.Drawing.Point(12, 13);
            this.data_HD.Name = "data_HD";
            this.data_HD.ReadOnly = true;
            this.data_HD.RowHeadersWidth = 62;
            this.data_HD.RowTemplate.Height = 28;
            this.data_HD.Size = new System.Drawing.Size(776, 425);
            this.data_HD.TabIndex = 12;
            // 
            // TraCuuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_HD);
            this.Name = "TraCuuHoaDon";
            this.Text = "TraCuuHoaDon";
            this.Load += new System.EventHandler(this.TraCuuHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_HD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView data_HD;
    }
}