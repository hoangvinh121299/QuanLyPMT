using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DAL
{
    public class HoatDongTaiKhoan_DAL
    {
        //Lấy thông tin đăng nhập
        public DataSet getHistoryByMaTaiKhoan(int MATAIKHOAN)
        {
            DataSet dataHoatDongTaiKhoan = new DataSet();
            string selectAll = "select * from HOATDONGTAIKHOAN where MATAIKHOAN =@MATAIKHOAN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand select = new SqlCommand(selectAll,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(select);
                select.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                adapter.Fill(dataHoatDongTaiKhoan);
                connection.Close();
            }
            return dataHoatDongTaiKhoan;
        }
        //Thêm thông tin tài khoản 
        public void addHoatDongTaiKhoan(int MATAIKHOAN, DateTime DANGNHAP, DateTime DANGXUAT, TimeSpan THOILUONG)
        {
            string insertInto = "insert into HOATDONGTAIKHOAN values (@MATAIKHOAN, @DANGNHAP,@DANGXUAT, @THOILUONG)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);
                    cmdInsert.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                    cmdInsert.Parameters.Add("@DANGNHAP", SqlDbType.DateTime).Value = DANGNHAP;
                    cmdInsert.Parameters.Add("@DANGXUAT", SqlDbType.DateTime).Value = DANGXUAT;
                    cmdInsert.Parameters.Add("@THOILUONG", SqlDbType.Time).Value = THOILUONG;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }
        }
    }
}
