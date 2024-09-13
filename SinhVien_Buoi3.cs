using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Buoi3
{
    internal class SinhVien_Buoi3
    {
        public int Masv;
        public string Hovaten;
        public string Ngaysinh;
        public int Sodienthoai;
        public string Gioitinh;

        public void setMasv(in int Masv)
        {
            this.Masv = Masv;
        }
        public int getMasv()
        {

            return this.Masv; }


        public void sethovaten(string Hovaten)
        {
            this.Hovaten = Hovaten;
        }

        public string getHovaten()
        {

            return this.Hovaten;
        }
        public void setNgaysinh(string Ngaysinh)
        {
            this.Ngaysinh = Ngaysinh;
        }
        public string getNgaysinh()
        {

            return this.Ngaysinh;
        }

        public void setSoDienThoai(int SoDienThoai)
        {
            this.Sodienthoai = SoDienThoai ;
        }
        public int getSoDienThoai()
        {

            return this.Sodienthoai;
        }
        public void setGioitinh(string Gioitinh)
        {
            this.Gioitinh = Gioitinh;
        }
        public string getGioitinh()
        {

            return this.Gioitinh;
        }



    }
    
}
