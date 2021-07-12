namespace PTTK
{
    partial class QuanLyHocTap
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
            this.data_HV = new System.Windows.Forms.DataGridView();
            this.butt_TraCuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butt_Chungchi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_HV)).BeginInit();
            this.SuspendLayout();
            // 
            // data_HV
            // 
            this.data_HV.AllowUserToAddRows = false;
            this.data_HV.AllowUserToDeleteRows = false;
            this.data_HV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_HV.Location = new System.Drawing.Point(13, 13);
            this.data_HV.Name = "data_HV";
            this.data_HV.ReadOnly = true;
            this.data_HV.RowHeadersWidth = 62;
            this.data_HV.RowTemplate.Height = 28;
            this.data_HV.Size = new System.Drawing.Size(585, 425);
            this.data_HV.TabIndex = 0;
            // 
            // butt_TraCuu
            // 
            this.butt_TraCuu.Location = new System.Drawing.Point(610, 132);
            this.butt_TraCuu.Name = "butt_TraCuu";
            this.butt_TraCuu.Size = new System.Drawing.Size(172, 44);
            this.butt_TraCuu.TabIndex = 1;
            this.butt_TraCuu.Text = "Tra cuu Ket qua";
            this.butt_TraCuu.UseVisualStyleBackColor = true;
            this.butt_TraCuu.Click += new System.EventHandler(this.butt_TraCuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hoc Ky";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khoa";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(670, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "1";
            this.comboBox1.ValueMember = "1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(669, 50);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // butt_Chungchi
            // 
            this.butt_Chungchi.Location = new System.Drawing.Point(609, 221);
            this.butt_Chungchi.Name = "butt_Chungchi";
            this.butt_Chungchi.Size = new System.Drawing.Size(172, 44);
            this.butt_Chungchi.TabIndex = 1;
            this.butt_Chungchi.Text = "Tra cuu Chung chi";
            this.butt_Chungchi.UseVisualStyleBackColor = true;
            this.butt_Chungchi.Click += new System.EventHandler(this.butt_Chungchi_Click);
            // 
            // QuanLyHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.butt_Chungchi);
            this.Controls.Add(this.butt_TraCuu);
            this.Controls.Add(this.data_HV);
            this.Name = "QuanLyHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHocTap";
            this.Load += new System.EventHandler(this.QuanLyHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_HV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_HV;
        private System.Windows.Forms.Button butt_TraCuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button butt_Chungchi;
    }
}