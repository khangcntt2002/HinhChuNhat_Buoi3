namespace HinhChuNhat_Buoi3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_msv = new TextBox();
            txt_hoten = new TextBox();
            txt_sdt = new TextBox();
            txt_gioitinh = new TextBox();
            button1 = new Button();
            dt_Ngaysinh = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            txt_stk = new TextBox();
            txt_nh = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(21, 21);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 1;
            label3.Text = "Mã SV";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(21, 49);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 1;
            label4.Text = "Họ Tên";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(13, 82);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 1;
            label5.Text = "Ngày Sinh";
            label5.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(20, 119);
            label6.Name = "label6";
            label6.Size = new Size(50, 19);
            label6.TabIndex = 1;
            label6.Text = "Số ĐT";
            label6.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(352, 14);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 1;
            label7.Text = "Giới Tính";
            label7.Click += label2_Click;
            // 
            // txt_msv
            // 
            txt_msv.Font = new Font("Times New Roman", 12F);
            txt_msv.Location = new Point(106, 12);
            txt_msv.Name = "txt_msv";
            txt_msv.Size = new Size(216, 26);
            txt_msv.TabIndex = 2;
            txt_msv.TextChanged += textBox1_TextChanged;
            // 
            // txt_hoten
            // 
            txt_hoten.Font = new Font("Times New Roman", 12F);
            txt_hoten.Location = new Point(105, 44);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(217, 26);
            txt_hoten.TabIndex = 2;
            txt_hoten.TextChanged += textBox1_TextChanged;
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Times New Roman", 12F);
            txt_sdt.Location = new Point(105, 115);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(216, 26);
            txt_sdt.TabIndex = 2;
            txt_sdt.TextChanged += textBox1_TextChanged;
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Font = new Font("Times New Roman", 12F);
            txt_gioitinh.Location = new Point(437, 14);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(216, 26);
            txt_gioitinh.TabIndex = 2;
            txt_gioitinh.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(370, 114);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 3;
            button1.Text = "Tìm Thông Tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dt_Ngaysinh
            // 
            dt_Ngaysinh.Location = new Point(106, 86);
            dt_Ngaysinh.Name = "dt_Ngaysinh";
            dt_Ngaysinh.Size = new Size(216, 23);
            dt_Ngaysinh.TabIndex = 4;
            dt_Ngaysinh.ValueChanged += dt_Ngaysinh_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F);
            label8.Location = new Point(352, 50);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 1;
            label8.Text = "Số TK";
            label8.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F);
            label9.Location = new Point(352, 82);
            label9.Name = "label9";
            label9.Size = new Size(78, 19);
            label9.TabIndex = 1;
            label9.Text = "Ngân Hàng";
            label9.Click += label2_Click;
            // 
            // txt_stk
            // 
            txt_stk.Font = new Font("Times New Roman", 12F);
            txt_stk.Location = new Point(437, 46);
            txt_stk.Name = "txt_stk";
            txt_stk.Size = new Size(216, 26);
            txt_stk.TabIndex = 2;
            txt_stk.TextChanged += textBox1_TextChanged;
            // 
            // txt_nh
            // 
            txt_nh.Font = new Font("Times New Roman", 12F);
            txt_nh.Location = new Point(437, 82);
            txt_nh.Name = "txt_nh";
            txt_nh.Size = new Size(216, 26);
            txt_nh.TabIndex = 2;
            txt_nh.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(693, 165);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(515, 121);
            button2.Name = "button2";
            button2.Size = new Size(83, 38);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 358);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(dt_Ngaysinh);
            Controls.Add(button1);
            Controls.Add(txt_nh);
            Controls.Add(txt_gioitinh);
            Controls.Add(txt_stk);
            Controls.Add(txt_sdt);
            Controls.Add(txt_hoten);
            Controls.Add(txt_msv);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_msv;
        private TextBox txt_hoten;
        private TextBox txt_sdt;
        private TextBox txt_gioitinh;
        private Button button1;
        private DateTimePicker dt_Ngaysinh;
        private Label label8;
        private Label label9;
        private TextBox txt_stk;
        private TextBox txt_nh;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
