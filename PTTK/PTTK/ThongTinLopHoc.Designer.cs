namespace PTTK
{
    partial class Thong_tin_Lop_hoc
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
            this.data_Lop = new System.Windows.Forms.DataGridView();
            this.tb_MaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butt_Xem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_HK = new System.Windows.Forms.ComboBox();
            this.dt_Khoa = new System.Windows.Forms.DateTimePicker();
            this.butt_TraCuu = new System.Windows.Forms.Button();
            this.tb_SiSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_them = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Lop
            // 
            this.data_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Lop.Location = new System.Drawing.Point(13, 13);
            this.data_Lop.Name = "data_Lop";
            this.data_Lop.RowHeadersWidth = 62;
            this.data_Lop.RowTemplate.Height = 28;
            this.data_Lop.Size = new System.Drawing.Size(577, 425);
            this.data_Lop.TabIndex = 0;
            // 
            // tb_MaLop
            // 
            this.tb_MaLop.Location = new System.Drawing.Point(676, 180);
            this.tb_MaLop.Name = "tb_MaLop";
            this.tb_MaLop.Size = new System.Drawing.Size(111, 26);
            this.tb_MaLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ma lop";
            // 
            // butt_Xem
            // 
            this.butt_Xem.Location = new System.Drawing.Point(615, 212);
            this.butt_Xem.Name = "butt_Xem";
            this.butt_Xem.Size = new System.Drawing.Size(172, 34);
            this.butt_Xem.TabIndex = 3;
            this.butt_Xem.Text = "Xem Lop";
            this.butt_Xem.UseVisualStyleBackColor = true;
            this.butt_Xem.Click += new System.EventHandler(this.butt_Xem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hoc Ky";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Khoa";
            // 
            // cb_HK
            // 
            this.cb_HK.DisplayMember = "1";
            this.cb_HK.FormattingEnabled = true;
            this.cb_HK.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_HK.Location = new System.Drawing.Point(677, 48);
            this.cb_HK.Name = "cb_HK";
            this.cb_HK.Size = new System.Drawing.Size(111, 28);
            this.cb_HK.TabIndex = 14;
            this.cb_HK.Text = "1";
            this.cb_HK.ValueMember = "1";
            // 
            // dt_Khoa
            // 
            this.dt_Khoa.CustomFormat = "yyyy";
            this.dt_Khoa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Khoa.Location = new System.Drawing.Point(676, 13);
            this.dt_Khoa.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dt_Khoa.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dt_Khoa.Name = "dt_Khoa";
            this.dt_Khoa.ShowUpDown = true;
            this.dt_Khoa.Size = new System.Drawing.Size(112, 26);
            this.dt_Khoa.TabIndex = 13;
            // 
            // butt_TraCuu
            // 
            this.butt_TraCuu.Location = new System.Drawing.Point(616, 95);
            this.butt_TraCuu.Name = "butt_TraCuu";
            this.butt_TraCuu.Size = new System.Drawing.Size(173, 34);
            this.butt_TraCuu.TabIndex = 12;
            this.butt_TraCuu.Text = "Tra cuu";
            this.butt_TraCuu.UseVisualStyleBackColor = true;
            this.butt_TraCuu.Click += new System.EventHandler(this.butt_TraCuu_Click);
            // 
            // tb_SiSo
            // 
            this.tb_SiSo.Location = new System.Drawing.Point(676, 295);
            this.tb_SiSo.Name = "tb_SiSo";
            this.tb_SiSo.Size = new System.Drawing.Size(111, 26);
            this.tb_SiSo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Si so";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cap nhat Si so";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_them
            // 
            this.tb_them.Location = new System.Drawing.Point(676, 327);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(111, 26);
            this.tb_them.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Them";
            // 
            // Thong_tin_Lop_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_them);
            this.Controls.Add(this.tb_SiSo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_HK);
            this.Controls.Add(this.dt_Khoa);
            this.Controls.Add(this.butt_TraCuu);
            this.Controls.Add(this.butt_Xem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_MaLop);
            this.Controls.Add(this.data_Lop);
            this.Name = "Thong_tin_Lop_hoc";
            this.Text = "Thong Tin Lop Hoc";
            this.Load += new System.EventHandler(this.Thong_tin_Lop_hoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Lop;
        private System.Windows.Forms.TextBox tb_MaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butt_Xem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_HK;
        private System.Windows.Forms.DateTimePicker dt_Khoa;
        private System.Windows.Forms.Button butt_TraCuu;
        private System.Windows.Forms.TextBox tb_SiSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_them;
        private System.Windows.Forms.Label label3;
    }
}