using BaiTap_Buoi3;

namespace HinhChuNhat_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            HinhChuNhat hinhchunhat = new HinhChuNhat();

            hinhchunhat.setChieudai(int.Parse(txt_Dai.Text));
            hinhchunhat.setChieurong(int.Parse(txt_Rong.Text));

            MessageBox.Show("Chiều Dài:" + hinhchunhat.getChieudai() + "\n Chiều Rộng:" + hinhchunhat.getChieurong());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien_Buoi3 Sinhvienbuoi3 = new SinhVien_Buoi3();
            Sinhvienbuoi3.setMasv(int.Parse(txt_msv.Text));
            Sinhvienbuoi3.sethovaten(txt_hoten.Text);
            Sinhvienbuoi3.setNgaysinh(txt_ngaysinh.Text);
            Sinhvienbuoi3.setSoDienThoai(int.Parse(txt_sdt.Text));
            Sinhvienbuoi3.setGioitinh(txt_gioitinh.Text);
            MessageBox.Show("Mã SV:" + Sinhvienbuoi3.getMasv() + "\n Họ Và Tên:" + Sinhvienbuoi3.getHovaten() + "\n Ngày Sinh:" + Sinhvienbuoi3.getNgaysinh() + "\n SỐ ĐT: " + Sinhvienbuoi3.getSoDienThoai() + "\n Giới Tính:" + Sinhvienbuoi3.getGioitinh());
        }
    }
}
