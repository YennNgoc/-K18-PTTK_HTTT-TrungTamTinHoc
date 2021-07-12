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
            this.tb_maHV = new System.Windows.Forms.TextBox();
            this.cb_ChungChi = new System.Windows.Forms.ComboBox();
            this.btn_XetTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(536, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // bth_XemLSTN
            // 
            this.bth_XemLSTN.Location = new System.Drawing.Point(579, 302);
            this.bth_XemLSTN.Name = "bth_XemLSTN";
            this.bth_XemLSTN.Size = new System.Drawing.Size(209, 40);
            this.bth_XemLSTN.TabIndex = 1;
            this.bth_XemLSTN.Text = "Xem Toan bo LSTN";
            this.bth_XemLSTN.UseVisualStyleBackColor = true;
            this.bth_XemLSTN.Click += new System.EventHandler(this.bth_XemLSTN_Click);
            // 
            // tb_maHV
            // 
            this.tb_maHV.Location = new System.Drawing.Point(579, 42);
            this.tb_maHV.Name = "tb_maHV";
            this.tb_maHV.Size = new System.Drawing.Size(209, 26);
            this.tb_maHV.TabIndex = 2;
            // 
            // cb_ChungChi
            // 
            this.cb_ChungChi.FormattingEnabled = true;
            this.cb_ChungChi.Location = new System.Drawing.Point(579, 112);
            this.cb_ChungChi.Name = "cb_ChungChi";
            this.cb_ChungChi.Size = new System.Drawing.Size(209, 28);
            this.cb_ChungChi.TabIndex = 3;
            // 
            // btn_XetTN
            // 
            this.btn_XetTN.Location = new System.Drawing.Point(579, 227);
            this.btn_XetTN.Name = "btn_XetTN";
            this.btn_XetTN.Size = new System.Drawing.Size(209, 40);
            this.btn_XetTN.TabIndex = 4;
            this.btn_XetTN.Text = "Xet Tot nghiep";
            this.btn_XetTN.UseVisualStyleBackColor = true;
            this.btn_XetTN.Click += new System.EventHandler(this.btn_XetTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(579, 184);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ma Hoc vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ma Chung chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngay nhan";
            // 
            // XetTotNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_XetTN);
            this.Controls.Add(this.cb_ChungChi);
            this.Controls.Add(this.tb_maHV);
            this.Controls.Add(this.bth_XemLSTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XetTotNghiep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XetTotNghiep";
            this.Load += new System.EventHandler(this.XetTotNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bth_XemLSTN;
        private System.Windows.Forms.TextBox tb_maHV;
        private System.Windows.Forms.ComboBox cb_ChungChi;
        private System.Windows.Forms.Button btn_XetTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}