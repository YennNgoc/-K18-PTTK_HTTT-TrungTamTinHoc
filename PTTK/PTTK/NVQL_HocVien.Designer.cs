namespace PTTK
{
    partial class NVQL_HocVien
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhomMH = new System.Windows.Forms.ComboBox();
            this.grid_NVQLHV = new System.Windows.Forms.DataGridView();
            this.checked_HP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.butt_info = new System.Windows.Forms.Button();
            this.but_TraCuuHV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLHV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(653, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ten";
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.Location = new System.Drawing.Point(114, 9);
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Size = new System.Drawing.Size(120, 26);
            this.tb_MaHV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ma Hoc vien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhom";
            // 
            // cb_nhomMH
            // 
            this.cb_nhomMH.FormattingEnabled = true;
            this.cb_nhomMH.Location = new System.Drawing.Point(467, 12);
            this.cb_nhomMH.Name = "cb_nhomMH";
            this.cb_nhomMH.Size = new System.Drawing.Size(156, 28);
            this.cb_nhomMH.TabIndex = 8;
            // 
            // grid_NVQLHV
            // 
            this.grid_NVQLHV.AllowUserToAddRows = false;
            this.grid_NVQLHV.AllowUserToDeleteRows = false;
            this.grid_NVQLHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NVQLHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checked_HP});
            this.grid_NVQLHV.Location = new System.Drawing.Point(15, 57);
            this.grid_NVQLHV.Name = "grid_NVQLHV";
            this.grid_NVQLHV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid_NVQLHV.RowHeadersVisible = false;
            this.grid_NVQLHV.RowHeadersWidth = 62;
            this.grid_NVQLHV.RowTemplate.Height = 28;
            this.grid_NVQLHV.Size = new System.Drawing.Size(608, 336);
            this.grid_NVQLHV.TabIndex = 7;
            // 
            // checked_HP
            // 
            this.checked_HP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.checked_HP.FillWeight = 50F;
            this.checked_HP.HeaderText = "Chon";
            this.checked_HP.MinimumWidth = 8;
            this.checked_HP.Name = "checked_HP";
            this.checked_HP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checked_HP.Visible = false;
            this.checked_HP.Width = 50;
            // 
            // butt_info
            // 
            this.butt_info.Location = new System.Drawing.Point(653, 106);
            this.butt_info.Name = "butt_info";
            this.butt_info.Size = new System.Drawing.Size(205, 39);
            this.butt_info.TabIndex = 5;
            this.butt_info.Text = "Thong tin Lop";
            this.butt_info.UseVisualStyleBackColor = true;
            // 
            // but_TraCuuHV
            // 
            this.but_TraCuuHV.Location = new System.Drawing.Point(653, 57);
            this.but_TraCuuHV.Name = "but_TraCuuHV";
            this.but_TraCuuHV.Size = new System.Drawing.Size(205, 39);
            this.but_TraCuuHV.TabIndex = 6;
            this.but_TraCuuHV.Text = "Tra cuu Hoc vien";
            this.but_TraCuuHV.UseVisualStyleBackColor = true;
            this.but_TraCuuHV.Click += new System.EventHandler(this.but_TraCuuHV_Click);
            // 
            // NVQL_HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 555);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_nhomMH);
            this.Controls.Add(this.grid_NVQLHV);
            this.Controls.Add(this.butt_info);
            this.Controls.Add(this.but_TraCuuHV);
            this.Name = "NVQL_HocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NVQL_HocVien";
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLHV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhomMH;
        private System.Windows.Forms.DataGridView grid_NVQLHV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checked_HP;
        private System.Windows.Forms.Button butt_info;
        private System.Windows.Forms.Button but_TraCuuHV;
    }
}