namespace PTTK
{
    partial class ThuNgan
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhomMH = new System.Windows.Forms.ComboBox();
            this.grid_NVQLLH = new System.Windows.Forms.DataGridView();
            this.checked_HP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_TraCuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLLH)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(700, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ma HV";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(700, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ma Mon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhom";
            // 
            // cb_nhomMH
            // 
            this.cb_nhomMH.FormattingEnabled = true;
            this.cb_nhomMH.Location = new System.Drawing.Point(700, 92);
            this.cb_nhomMH.Name = "cb_nhomMH";
            this.cb_nhomMH.Size = new System.Drawing.Size(156, 28);
            this.cb_nhomMH.TabIndex = 9;
            // 
            // grid_NVQLLH
            // 
            this.grid_NVQLLH.AllowUserToAddRows = false;
            this.grid_NVQLLH.AllowUserToDeleteRows = false;
            this.grid_NVQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NVQLLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checked_HP});
            this.grid_NVQLLH.Location = new System.Drawing.Point(15, 63);
            this.grid_NVQLLH.Name = "grid_NVQLLH";
            this.grid_NVQLLH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid_NVQLLH.RowHeadersVisible = false;
            this.grid_NVQLLH.RowHeadersWidth = 62;
            this.grid_NVQLLH.RowTemplate.Height = 28;
            this.grid_NVQLLH.Size = new System.Drawing.Size(605, 336);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xem Hoa Don";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Them Hoc phan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // but_TraCuu
            // 
            this.but_TraCuu.Location = new System.Drawing.Point(15, 12);
            this.but_TraCuu.Name = "but_TraCuu";
            this.but_TraCuu.Size = new System.Drawing.Size(182, 39);
            this.but_TraCuu.TabIndex = 7;
            this.but_TraCuu.Text = "Tra cuu Hoc phan";
            this.but_TraCuu.UseVisualStyleBackColor = true;
            // 
            // ThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 555);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_nhomMH);
            this.Controls.Add(this.grid_NVQLLH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_TraCuu);
            this.Name = "ThuNgan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThuNgan";
            ((System.ComponentModel.ISupportInitialize)(this.grid_NVQLLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhomMH;
        private System.Windows.Forms.DataGridView grid_NVQLLH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checked_HP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_TraCuu;
    }
}