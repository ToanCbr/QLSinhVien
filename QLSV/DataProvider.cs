using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public class DataProvider
    {
        const string connString = "Data Source=LAPTOP-OFAIU6RC\\SQLEXPRESS;Initial Catalog=BT_Tuan7_QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static List<DangNhap> DangNhaps = new List<DangNhap> ();
        public static void OpenConnection()
        {
            connection = new SqlConnection(connString);
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }

        public static void GetAlDangNhap()
        {
            try
            {
                OpenConnection();
                string query = "Select * From DangNhap";
                SqlCommand Command = new SqlCommand(query,connection);
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    DangNhap dangnhap = new DangNhap();
                    dangnhap.TaiKhoan = reader["TenDangNhap"].ToString();
                    dangnhap.MatKhau = reader["MatKhau"].ToString();
                    dangnhap.HoTen = reader["HoTen"].ToString();
                    dangnhap.Quyen = reader["Quyen"].ToString();
                    DangNhaps.Add(dangnhap);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static DataTable LoadCSDL(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query,connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public static int ThaoTacCSDL(string query)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                kq = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }
    }
}
