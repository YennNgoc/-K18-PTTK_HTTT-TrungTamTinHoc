namespace PTTK
{
    partial class MoLichThi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_maLop = new System.Windows.Forms.TextBox();
            this.tb_DiaDiem = new System.Windows.Forms.TextBox();
            this.tb_gio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_MoLichThi = new System.Windows.Forms.Button();
            this.btn_XemLichThi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(533, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_maLop
            // 
            this.tb_maLop.Location = new System.Drawing.Point(566, 61);
            this.tb_maLop.Name = "tb_maLop";
            this.tb_maLop.Size = new System.Drawing.Size(218, 26);
            this.tb_maLop.TabIndex = 1;
            // 
            // tb_DiaDiem
            // 
            this.tb_DiaDiem.Location = new System.Drawing.Point(566, 119);
            this.tb_DiaDiem.Name = "tb_DiaDiem";
            this.tb_DiaDiem.Size = new System.Drawing.Size(218, 26);
            this.tb_DiaDiem.TabIndex = 2;
            // 
            // tb_gio
            // 
            this.tb_gio.Location = new System.Drawing.Point(566, 187);
            this.tb_gio.Name = "tb_gio";
            this.tb_gio.Size = new System.Drawing.Size(218, 26);
            this.tb_gio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Format: yyyy-MM-dd hh:mm:ss";
            // 
            // but_MoLichThi
            // 
            this.but_MoLichThi.Location = new System.Drawing.Point(566, 277);
            this.but_MoLichThi.Name = "but_MoLichThi";
            this.but_MoLichThi.Size = new System.Drawing.Size(218, 47);
            this.but_MoLichThi.TabIndex = 5;
            this.but_MoLichThi.Text = "Mo Lich Thi";
            this.but_MoLichThi.UseVisualStyleBackColor = true;
            this.but_MoLichThi.Click += new System.EventHandler(this.btn_MoLichThi_Click);
            // 
            // btn_XemLichThi
            // 
            this.btn_XemLichThi.Location = new System.Drawing.Point(566, 340);
            this.btn_XemLichThi.Name = "btn_XemLichThi";
            this.btn_XemLichThi.Size = new System.Drawing.Size(218, 47);
            this.btn_XemLichThi.TabIndex = 5;
            this.btn_XemLichThi.Text = "Xem Lich Thi";
            this.btn_XemLichThi.UseVisualStyleBackColor = true;
            this.btn_XemLichThi.Click += new System.EventHandler(this.btn_XemLichThi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngay - Gio Thi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia Diem";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ma Lop";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // MoLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_XemLichThi);
            this.Controls.Add(this.but_MoLichThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_gio);
            this.Controls.Add(this.tb_DiaDiem);
            this.Controls.Add(this.tb_maLop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MoLichThi";
            this.Text = "MoLichThi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_maLop;
        private System.Windows.Forms.TextBox tb_DiaDiem;
        private System.Windows.Forms.TextBox tb_gio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_MoLichThi;
        private System.Windows.Forms.Button btn_XemLichThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}