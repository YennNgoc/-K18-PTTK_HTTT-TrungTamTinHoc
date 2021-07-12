namespace PTTK
{
    partial class DangKyHocPhan
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
            this.butt_DSLop = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_KetQuaDK = new System.Windows.Forms.Button();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // butt_DSLop
            // 
            this.butt_DSLop.Location = new System.Drawing.Point(395, 25);
            this.butt_DSLop.Name = "butt_DSLop";
            this.butt_DSLop.Size = new System.Drawing.Size(185, 43);
            this.butt_DSLop.TabIndex = 1;
            this.butt_DSLop.Text = "Danh sach Lop mo";
            this.butt_DSLop.UseVisualStyleBackColor = true;
            this.butt_DSLop.Click += new System.EventHandler(this.butt_DSLop_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(603, 87);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(185, 43);
            this.btn_DangKy.TabIndex = 1;
            this.btn_DangKy.Text = "Dang ky";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_KetQuaDK
            // 
            this.btn_KetQuaDK.Location = new System.Drawing.Point(395, 87);
            this.btn_KetQuaDK.Name = "btn_KetQuaDK";
            this.btn_KetQuaDK.Size = new System.Drawing.Size(185, 43);
            this.btn_KetQuaDK.TabIndex = 1;
            this.btn_KetQuaDK.Text = "Ket qua Dang ky";
            this.btn_KetQuaDK.UseVisualStyleBackColor = true;
            this.btn_KetQuaDK.Click += new System.EventHandler(this.btn_KetQuaDK_Click);
            // 
            // tb_malop
            // 
            this.tb_malop.Location = new System.Drawing.Point(603, 48);
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.Size = new System.Drawing.Size(185, 26);
            this.tb_malop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ma lop";
            // 
            // DangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.btn_KetQuaDK);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.butt_DSLop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DangKyHocPhan";
            this.Text = "DangKyHocPhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butt_DSLop;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_KetQuaDK;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.Label label1;
    }
}