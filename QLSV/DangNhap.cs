using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class DangNhap
    {
        public string TaiKhoan {  get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Quyen { get; set; }

        public DangNhap() { }
        public DangNhap(string taikhoan, string matkhau, string hoten, string quyen)
        {
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
            HoTen = hoten;
            Quyen = quyen;
        }
    }
}
