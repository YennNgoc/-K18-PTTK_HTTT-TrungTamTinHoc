namespace PTTK
{
    partial class ChinhSuaDiem
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
            this.tb_Lop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butt_xem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DiemMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butt_UPD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Lop
            // 
            this.tb_Lop.Location = new System.Drawing.Point(123, 12);
            this.tb_Lop.Name = "tb_Lop";
            this.tb_Lop.Size = new System.Drawing.Size(112, 26);
            this.tb_Lop.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ma Lop";
            // 
            // tb_MaHV
            // 
            this.tb_MaHV.Location = new System.Drawing.Point(123, 44);
            this.tb_MaHV.Name = "tb_MaHV";
            this.tb_MaHV.Size = new System.Drawing.Size(112, 26);
            this.tb_MaHV.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ma Hoc vien";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(744, 98);
            this.dataGridView1.TabIndex = 26;
            // 
            // butt_xem
            // 
            this.butt_xem.Location = new System.Drawing.Point(25, 80);
            this.butt_xem.Name = "butt_xem";
            this.butt_xem.Size = new System.Drawing.Size(210, 40);
            this.butt_xem.TabIndex = 27;
            this.butt_xem.Text = "Xem diem";
            this.butt_xem.UseVisualStyleBackColor = true;
            this.butt_xem.Click += new System.EventHandler(this.butt_xem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Diem ";
            // 
            // tb_DiemMoi
            // 
            this.tb_DiemMoi.Location = new System.Drawing.Point(393, 44);
            this.tb_DiemMoi.Name = "tb_DiemMoi";
            this.tb_DiemMoi.Size = new System.Drawing.Size(128, 26);
            this.tb_DiemMoi.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Diem moi";
            // 
            // butt_UPD
            // 
            this.butt_UPD.Location = new System.Drawing.Point(311, 80);
            this.butt_UPD.Name = "butt_UPD";
            this.butt_UPD.Size = new System.Drawing.Size(210, 40);
            this.butt_UPD.TabIndex = 30;
            this.butt_UPD.Text = "Cap nhat";
            this.butt_UPD.UseVisualStyleBackColor = true;
            this.butt_UPD.Click += new System.EventHandler(this.butt_UPD_Click);
            // 
            // ChinhSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_UPD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_DiemMoi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butt_xem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_Lop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MaHV);
            this.Controls.Add(this.label2);
            this.Name = "ChinhSuaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChinhSuaDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butt_xem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DiemMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butt_UPD;
    }
}