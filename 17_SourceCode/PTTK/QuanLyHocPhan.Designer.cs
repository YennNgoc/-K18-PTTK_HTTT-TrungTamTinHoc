namespace PTTK
{
    partial class QuanLyHocPhan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhomMH = new System.Windows.Forms.ComboBox();
            this.grid_NVQLLH = new System.Windows.Forms.DataGridView();
            this.checked_HP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.but_Xoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_TraCuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLLH)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ma Mon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhom";
            // 
            // cb_nhomMH
            // 
            this.cb_nhomMH.FormattingEnabled = true;
            this.cb_nhomMH.Location = new System.Drawing.Point(630, 91);
            this.cb_nhomMH.Name = "cb_nhomMH";
            this.cb_nhomMH.Size = new System.Drawing.Size(158, 28);
            this.cb_nhomMH.TabIndex = 9;
            // 
            // grid_NVQLLH
            // 
            this.grid_NVQLLH.AllowUserToAddRows = false;
            this.grid_NVQLLH.AllowUserToDeleteRows = false;
            this.grid_NVQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NVQLLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checked_HP});
            this.grid_NVQLLH.Location = new System.Drawing.Point(12, 12);
            this.grid_NVQLLH.MultiSelect = false;
            this.grid_NVQLLH.Name = "grid_NVQLLH";
            this.grid_NVQLLH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid_NVQLLH.RowHeadersVisible = false;
            this.grid_NVQLLH.RowHeadersWidth = 62;
            this.grid_NVQLLH.RowTemplate.Height = 28;
            this.grid_NVQLLH.Size = new System.Drawing.Size(545, 420);
            this.grid_NVQLLH.TabIndex = 8;
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
            // but_Xoa
            // 
            this.but_Xoa.Location = new System.Drawing.Point(567, 190);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Size = new System.Drawing.Size(221, 39);
            this.but_Xoa.TabIndex = 5;
            this.but_Xoa.Text = "Xoa Hoc phan";
            this.but_Xoa.UseVisualStyleBackColor = true;
            this.but_Xoa.Click += new System.EventHandler(this.but_Xoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Them Hoc phan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_TraCuu
            // 
            this.but_TraCuu.Location = new System.Drawing.Point(567, 145);
            this.but_TraCuu.Name = "but_TraCuu";
            this.but_TraCuu.Size = new System.Drawing.Size(221, 39);
            this.but_TraCuu.TabIndex = 7;
            this.but_TraCuu.Text = "Tra cuu Hoc phan";
            this.but_TraCuu.UseVisualStyleBackColor = true;
            this.but_TraCuu.Click += new System.EventHandler(this.but_TraCuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ten";
            // 
            // tb_Ten
            // 
            this.tb_Ten.Location = new System.Drawing.Point(630, 271);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(158, 26);
            this.tb_Ten.TabIndex = 14;
            // 
            // QuanLyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_nhomMH);
            this.Controls.Add(this.grid_NVQLLH);
            this.Controls.Add(this.but_Xoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_TraCuu);
            this.Name = "QuanLyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHocPhan";
            this.Load += new System.EventHandler(this.QuanLyHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhomMH;
        private System.Windows.Forms.DataGridView grid_NVQLLH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checked_HP;
        private System.Windows.Forms.Button but_Xoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_TraCuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Ten;
    }
}