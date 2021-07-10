namespace PTTK
{
    partial class TraCuuHocVien
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
            this.tb_MaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_NVQLHV = new System.Windows.Forms.DataGridView();
            this.checked_HP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.butt_info = new System.Windows.Forms.Button();
            this.but_TraCuuHV = new System.Windows.Forms.Button();
            this.tb_tongsoHV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLHV)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.Location = new System.Drawing.Point(648, 163);
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Size = new System.Drawing.Size(205, 26);
            this.tb_MaHV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ma Hoc vien";
            // 
            // grid_NVQLHV
            // 
            this.grid_NVQLHV.AllowUserToAddRows = false;
            this.grid_NVQLHV.AllowUserToDeleteRows = false;
            this.grid_NVQLHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NVQLHV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checked_HP});
            this.grid_NVQLHV.Location = new System.Drawing.Point(15, 12);
            this.grid_NVQLHV.Name = "grid_NVQLHV";
            this.grid_NVQLHV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid_NVQLHV.RowHeadersVisible = false;
            this.grid_NVQLHV.RowHeadersWidth = 62;
            this.grid_NVQLHV.RowTemplate.Height = 28;
            this.grid_NVQLHV.Size = new System.Drawing.Size(608, 519);
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
            this.butt_info.Location = new System.Drawing.Point(648, 249);
            this.butt_info.Name = "butt_info";
            this.butt_info.Size = new System.Drawing.Size(205, 39);
            this.butt_info.TabIndex = 5;
            this.butt_info.Text = "Them Hoc vien";
            this.butt_info.UseVisualStyleBackColor = true;
            this.butt_info.Click += new System.EventHandler(this.butt_info_Click);
            // 
            // but_TraCuuHV
            // 
            this.but_TraCuuHV.Location = new System.Drawing.Point(648, 204);
            this.but_TraCuuHV.Name = "but_TraCuuHV";
            this.but_TraCuuHV.Size = new System.Drawing.Size(205, 39);
            this.but_TraCuuHV.TabIndex = 6;
            this.but_TraCuuHV.Text = "Xem Thong tin";
            this.but_TraCuuHV.UseVisualStyleBackColor = true;
            this.but_TraCuuHV.Click += new System.EventHandler(this.but_TraCuuHV_Click);
            // 
            // tb_tongsoHV
            // 
            this.tb_tongsoHV.Location = new System.Drawing.Point(753, 44);
            this.tb_tongsoHV.Name = "tb_tongsoHV";
            this.tb_tongsoHV.Size = new System.Drawing.Size(100, 26);
            this.tb_tongsoHV.TabIndex = 14;
            this.tb_tongsoHV.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tong So Hoc vien tai trung tam";
            // 
            // TraCuuHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_tongsoHV);
            this.Controls.Add(this.tb_MaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_NVQLHV);
            this.Controls.Add(this.butt_info);
            this.Controls.Add(this.but_TraCuuHV);
            this.Name = "TraCuuHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraCuuHocVien";
            this.Load += new System.EventHandler(this.NVQL_HocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLHV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_MaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_NVQLHV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checked_HP;
        private System.Windows.Forms.Button butt_info;
        private System.Windows.Forms.Button but_TraCuuHV;
        private System.Windows.Forms.TextBox tb_tongsoHV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}