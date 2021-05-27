using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DAL
{
    public class TaiKhoan_DAL
    {

        public DataSet getDataTaikhoan()
        {
            DataSet dataTaiKhoan = new DataSet();
            string selectAll = "Select * from Taikhoan";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);
                adapter.Fill(dataTaiKhoan);
                connection.Close();
            }
            return dataTaiKhoan;
        }

        //Thêm thông tin tài khoản 
        public void addTaikhoan(string TENDANGNHAP, string MATKHAU,int MANV, int CAPBAC)
        {
            string insertInto = "INSERT INTO TAIKHOAN VALUES (@TENDANGNHAP, @MATKHAU, @MANV,@CAPBAC)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar).Value = TENDANGNHAP;
                    cmdInsert.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MATKHAU;
                    cmdInsert.Parameters.Add("@MANV", SqlDbType.Int).Value = MANV;
                    cmdInsert.Parameters.Add("@CAPBAC", SqlDbType.Int).Value = CAPBAC;
                    

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }
        }
        //Hàm cập nhật thông tin Nhân viên 
        public void updateTaiKhoan(int MATAIKHOAN,string MATKHAU,int CAPBAC)
        {
            string updateInto = "update TAIKHOAN set MATKHAU= @MATKHAU, CAPBAC = @CAPBAC WHERE MATAIKHOAN = @MATAIKHOAN" ;
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                    cmdInsert.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MATKHAU;
                    cmdInsert.Parameters.Add("@CAPBAC", SqlDbType.Int).Value = CAPBAC;


                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Hàm xoá thông tin Nhân vi
        public void deletETaiKhoan(int MATAIKHOAN)
        {
            string deleteTable = "delete TAIKHOAN where MATAIKHOAN = @MATAIKHOAN";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Tìm kiếm thông tin Nhân viên
        public DataSet searchTaiKhoan(string TEMDANGNHAP)
        {
            DataSet searchResult = new DataSet();
            string searchQuerry = "select * from TaiKhoan where TENDANGNHAP like @TENDANGNHAP";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdSearch = new SqlCommand(searchQuerry, connection);
                cmdSearch.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar).Value = TEMDANGNHAP + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch);
                adapter.Fill(searchResult);
                connection.Close();
            }
            return searchResult;
        }
        public DataSet getHistoryLogin(int MATAIKHOAN)
        {
            DataSet getResult = new DataSet();
            string getQuerry = "select DANGNHAP, DANGXUAT, THOILUONG from TAIKHOAN, HOATDONGTAIKHOAN where HOATDONGTAIKHOAN.MATAIKHOAN = @MATAIKHOAN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdGet = new SqlCommand(getQuerry, connection);
                cmdGet.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                SqlDataAdapter adapter = new SqlDataAdapter(cmdGet);
                adapter.Fill(getResult);
                connection.Close();
            }
            return getResult;
        }
    }
}
