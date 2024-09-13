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
            btn_xuat = new Button();
            label1 = new Label();
            txt_Dai = new TextBox();
            label2 = new Label();
            txt_Rong = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_msv = new TextBox();
            txt_hoten = new TextBox();
            txt_ngaysinh = new TextBox();
            txt_sdt = new TextBox();
            txt_gioitinh = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_xuat
            // 
            btn_xuat.Font = new Font("Times New Roman", 12F);
            btn_xuat.Location = new Point(212, 286);
            btn_xuat.Name = "btn_xuat";
            btn_xuat.Size = new Size(75, 45);
            btn_xuat.TabIndex = 0;
            btn_xuat.Text = "Xuất";
            btn_xuat.UseVisualStyleBackColor = true;
            btn_xuat.Click += btn_xuat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(22, 271);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 1;
            label1.Text = "Chiều Dài";
            // 
            // txt_Dai
            // 
            txt_Dai.Font = new Font("Times New Roman", 12F);
            txt_Dai.Location = new Point(106, 264);
            txt_Dai.Name = "txt_Dai";
            txt_Dai.Size = new Size(100, 26);
            txt_Dai.TabIndex = 2;
            txt_Dai.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(22, 308);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 1;
            label2.Text = "Chiều Rộng";
            label2.Click += label2_Click;
            // 
            // txt_Rong
            // 
            txt_Rong.Font = new Font("Times New Roman", 12F);
            txt_Rong.Location = new Point(106, 305);
            txt_Rong.Name = "txt_Rong";
            txt_Rong.Size = new Size(100, 26);
            txt_Rong.TabIndex = 2;
            txt_Rong.TextChanged += textBox1_TextChanged;
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
            label6.Location = new Point(21, 119);
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
            label7.Location = new Point(21, 151);
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
            txt_msv.Size = new Size(148, 26);
            txt_msv.TabIndex = 2;
            txt_msv.TextChanged += textBox1_TextChanged;
            // 
            // txt_hoten
            // 
            txt_hoten.Font = new Font("Times New Roman", 12F);
            txt_hoten.Location = new Point(105, 44);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(149, 26);
            txt_hoten.TabIndex = 2;
            txt_hoten.TextChanged += textBox1_TextChanged;
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Font = new Font("Times New Roman", 12F);
            txt_ngaysinh.Location = new Point(105, 79);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(149, 26);
            txt_ngaysinh.TabIndex = 2;
            txt_ngaysinh.TextChanged += textBox1_TextChanged;
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Times New Roman", 12F);
            txt_sdt.Location = new Point(106, 115);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(148, 26);
            txt_sdt.TabIndex = 2;
            txt_sdt.TextChanged += textBox1_TextChanged;
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Font = new Font("Times New Roman", 12F);
            txt_gioitinh.Location = new Point(106, 151);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(148, 26);
            txt_gioitinh.TabIndex = 2;
            txt_gioitinh.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(290, 70);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 3;
            button1.Text = "Tìm Thông Tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 358);
            Controls.Add(button1);
            Controls.Add(txt_gioitinh);
            Controls.Add(txt_sdt);
            Controls.Add(txt_ngaysinh);
            Controls.Add(txt_hoten);
            Controls.Add(txt_msv);
            Controls.Add(txt_Rong);
            Controls.Add(txt_Dai);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_xuat);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_xuat;
        private Label label1;
        private TextBox txt_Dai;
        private Label label2;
        private TextBox txt_Rong;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_msv;
        private TextBox txt_hoten;
        private TextBox txt_ngaysinh;
        private TextBox txt_sdt;
        private TextBox txt_gioitinh;
        private Button button1;
    }
}
