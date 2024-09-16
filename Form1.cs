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




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        List<SinhVien_Buoi3> li_sv = new List<SinhVien_Buoi3>();

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien_Buoi3 sv = new SinhVien_Buoi3(txt_msv.Text, txt_hoten.Text, dt_Ngaysinh.Value, txt_sdt.Text, txt_gioitinh.Text, txt_stk.Text, txt_nh.Text);

            li_sv.Remove(sv);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sv;

            
        }

        private void dt_Ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            li_sv.Remove(li_sv[0]);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sv;
        }
    }
}
