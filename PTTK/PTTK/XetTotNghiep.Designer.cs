namespace PTTK
{
    partial class XetTotNghiep
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
            this.bth_XemLSTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_ChungChi = new System.Windows.Forms.ComboBox();
            this.tb_NgayNhan = new System.Windows.Forms.TextBox();
            this.btn_XetTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(549, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // bth_XemLSTN
            // 
            this.bth_XemLSTN.Location = new System.Drawing.Point(579, 12);
            this.bth_XemLSTN.Name = "bth_XemLSTN";
            this.bth_XemLSTN.Size = new System.Drawing.Size(209, 40);
            this.bth_XemLSTN.TabIndex = 1;
            this.bth_XemLSTN.Text = "Xem Toan bo LSTN";
            this.bth_XemLSTN.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 2;
            // 
            // cb_ChungChi
            // 
            this.cb_ChungChi.FormattingEnabled = true;
            this.cb_ChungChi.Location = new System.Drawing.Point(579, 145);
            this.cb_ChungChi.Name = "cb_ChungChi";
            this.cb_ChungChi.Size = new System.Drawing.Size(209, 28);
            this.cb_ChungChi.TabIndex = 3;
            // 
            // tb_NgayNhan
            // 
            this.tb_NgayNhan.Location = new System.Drawing.Point(579, 211);
            this.tb_NgayNhan.Name = "tb_NgayNhan";
            this.tb_NgayNhan.Size = new System.Drawing.Size(209, 26);
            this.tb_NgayNhan.TabIndex = 2;
            // 
            // btn_XetTN
            // 
            this.btn_XetTN.Location = new System.Drawing.Point(579, 274);
            this.btn_XetTN.Name = "btn_XetTN";
            this.btn_XetTN.Size = new System.Drawing.Size(209, 40);
            this.btn_XetTN.TabIndex = 4;
            this.btn_XetTN.Text = "Xet Tot nghiep";
            this.btn_XetTN.UseVisualStyleBackColor = true;
            // 
            // XetTotNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_XetTN);
            this.Controls.Add(this.cb_ChungChi);
            this.Controls.Add(this.tb_NgayNhan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bth_XemLSTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XetTotNghiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XetTotNghiep";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bth_XemLSTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cb_ChungChi;
        private System.Windows.Forms.TextBox tb_NgayNhan;
        private System.Windows.Forms.Button btn_XetTN;
    }
}