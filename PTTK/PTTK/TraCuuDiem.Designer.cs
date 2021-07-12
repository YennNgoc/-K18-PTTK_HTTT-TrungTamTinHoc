namespace PTTK
{
    partial class TraCuuDiem
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
            this.grid_PKT = new System.Windows.Forms.DataGridView();
            this.checked_HP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.butt_Lop = new System.Windows.Forms.Button();
            this.but_Diem = new System.Windows.Forms.Button();
            this.tb_MaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Lop = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NMH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PKT)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_PKT
            // 
            this.grid_PKT.AllowUserToAddRows = false;
            this.grid_PKT.AllowUserToDeleteRows = false;
            this.grid_PKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_PKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checked_HP});
            this.grid_PKT.Location = new System.Drawing.Point(12, 12);
            this.grid_PKT.Name = "grid_PKT";
            this.grid_PKT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid_PKT.RowHeadersVisible = false;
            this.grid_PKT.RowHeadersWidth = 62;
            this.grid_PKT.RowTemplate.Height = 28;
            this.grid_PKT.Size = new System.Drawing.Size(608, 419);
            this.grid_PKT.TabIndex = 11;
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
            // butt_Lop
            // 
            this.butt_Lop.Location = new System.Drawing.Point(643, 192);
            this.butt_Lop.Name = "butt_Lop";
            this.butt_Lop.Size = new System.Drawing.Size(211, 39);
            this.butt_Lop.TabIndex = 9;
            this.butt_Lop.Text = "Tim theo Lop";
            this.butt_Lop.UseVisualStyleBackColor = true;
            this.butt_Lop.Click += new System.EventHandler(this.butt_info_Click);
            // 
            // but_Diem
            // 
            this.but_Diem.Location = new System.Drawing.Point(644, 89);
            this.but_Diem.Name = "but_Diem";
            this.but_Diem.Size = new System.Drawing.Size(211, 39);
            this.but_Diem.TabIndex = 10;
            this.but_Diem.Text = "Xem diem";
            this.but_Diem.UseVisualStyleBackColor = true;
            this.but_Diem.Click += new System.EventHandler(this.but_Lop_Click);
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.Location = new System.Drawing.Point(742, 57);
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Size = new System.Drawing.Size(112, 26);
            this.tb_MaHV.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ma Hoc vien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ma Lop";
            // 
            // tb_Lop
            // 
            this.tb_Lop.Location = new System.Drawing.Point(743, 160);
            this.tb_Lop.Name = "tb_Lop";
            this.tb_Lop.Size = new System.Drawing.Size(112, 26);
            this.tb_Lop.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 39);
            this.button3.TabIndex = 8;
            this.button3.Text = "Theo Nhom Mon hoc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ma nhom MH";
            // 
            // tb_NMH
            // 
            this.tb_NMH.Location = new System.Drawing.Point(743, 276);
            this.tb_NMH.Name = "tb_NMH";
            this.tb_NMH.Size = new System.Drawing.Size(112, 26);
            this.tb_NMH.TabIndex = 21;
            // 
            // TraCuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 467);
            this.Controls.Add(this.tb_NMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Lop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_PKT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butt_Lop);
            this.Controls.Add(this.but_Diem);
            this.Name = "TraCuuDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cuu Diem";
            this.Load += new System.EventHandler(this.TraCuuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_PKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_PKT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checked_HP;
        private System.Windows.Forms.Button butt_Lop;
        private System.Windows.Forms.Button but_Diem;
        private System.Windows.Forms.TextBox tb_MaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Lop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NMH;
    }
}