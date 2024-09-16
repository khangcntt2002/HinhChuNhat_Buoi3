using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Buoi3
{
    internal class SinhVien_Buoi3
    {
         string Masv;
         string Hovaten;
         DateTime Ngaysinh;
         string Sodienthoai;
         string Gioitinh;
         string STK;
         string NHang;

        
        public SinhVien_Buoi3(string Masv, string Hovaten, DateTime Ngaysinh, string SoDienThoai, string Gioitinh,string Stk,string NHang)
        {
            this.Masv1 = Masv;
            this.Hovaten1 = Hovaten;
            this.Ngaysinh1= Ngaysinh;
            this.Sodienthoai1= SoDienThoai;
            this.Gioitinh1= Gioitinh;
            this.STK1 = Stk;
            this.NHang1 = NHang;

        }

        public string Masv1 { get => Masv; set => Masv = value; }
        public string Hovaten1 { get => Hovaten; set => Hovaten = value; }
        public DateTime Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }
        public string Sodienthoai1 { get => Sodienthoai; set => Sodienthoai = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string STK1 { get => STK; set => STK = value; }
        public string NHang1 { get => NHang; set => NHang = value; }
    }
    
}
