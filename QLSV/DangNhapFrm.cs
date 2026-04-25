using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class DangNhapFrm : Form
    {
        public DangNhapFrm()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            bool isFound = false;
            foreach (var dn in DataProvider.DangNhaps)
            {
                if (dn.TaiKhoan == tenDangNhap && dn.MatKhau == matKhau)
                {
                    isFound = true; break;  
                }
            }
            if (isFound)
            {
                MainFrm f = new MainFrm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau");
            }
        }
        private void DangNhapFrm_Load(object sender, EventArgs e)
        {
            DataProvider.GetAlDangNhap();
        }
    }
}
