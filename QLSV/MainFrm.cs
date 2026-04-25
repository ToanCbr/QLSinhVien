using System;
using System.Collections;
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
    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            //query -> lay data tu csdl -> database -> datagridview
            LoadTabelMonHoc();
        }

        private void LoadTabelMonHoc()
        {
            string query = "select * from MonHoc";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
            UnEnableControls(new List<Control> { btnSua, btnXoa});
            ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            txtMaMH.Focus();
        }

        private void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }

        private void UnEnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }
        private void ResetText(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTiet = txtSoTiet.Text;

            string query = $"insert into MonHoc values ('{maMH}', N'{tenMH}', {soTiet})";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Them mon hoc thanh cong!");
                LoadTabelMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else MessageBox.Show("Khong the them mon hoc");
        }

        private void dtgvMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMH.SelectedRows.Count > 0)
            {
                //lay dong dc chon
                var dongDuocChon = dtgvMH.SelectedRows[0];

                //truyen gtri len cac textbox
                txtMaMH.Text = dongDuocChon.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = dongDuocChon.Cells["TenMH"].Value.ToString();
                txtSoTiet.Text = dongDuocChon.Cells["SoTiet"].Value.ToString();

                //Hien thi cac texbox, button
                EnableControls(new List<Control> { txtSoTiet, txtTenMH, btnXoa, btnSua });
                txtMaMH.Enabled = false;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTiet = txtSoTiet.Text;
            string query = $"Update MonHoc Set TenMH = N'{tenMH}', soTiet = {soTiet} WHERE MaMH = '{maMH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if(kq > 0)
            {
                MessageBox.Show("Sua mon hoc thanh cong!");
                LoadTabelMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu, btnSua, btnXoa });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else MessageBox.Show("Khong the sua mon hoc");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string query = $"DELETE MonHoc Where MaMH = '{maMH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xoa mon hoc thanh cong!");
                LoadTabelMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu, btnSua, btnXoa });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else MessageBox.Show("Khong the xoa mon hoc");
        }

        private void cbbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMaMH_Click(object sender, EventArgs e)
        {
            LoadComboMaMH();
        }
        private void LoadComboMaMH()
        {
            string query = "SELECT MaMH, TenMH from MonHoc";
            comboMaMH.DataSource = DataProvider.LoadCSDL(query);
            comboMaMH.DisplayMember = "TenMH";//Hien thi len combobox
            comboMaMH.ValueMember = "MaMH";//gia tri thuc cua combobox
        }

        private void btnTimMHTheoMa_Click(object sender, EventArgs e)
        {
            string maMH = (string) comboMaMH.SelectedValue;
            string query = $"select * from MonHoc Where maMH = '{maMH}'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnTuKhoa_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text;
            string query = $"select * from MonHoc Where tenMH LIKE N'%{tuKhoa}%'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }
    }
}

