using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class BenhNhan_DAL
    {
      
        public DataSet getDataBenhNhan()
        {
            DataSet dataBenhNhanh = new DataSet();
            string selectAll = "Select * from BenhNhan";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);
                adapter.Fill(dataBenhNhanh);
                connection.Close();
            }
                return dataBenhNhanh;
        }

        //Thêm thông tin bệnh nhân
        public void addBenhNhan( string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT)
        {
            string insertInto = "INSERT INTO BENHNHAN VALUES (@CMND,@NGAYSINH,@HOTEN,@GIOITINH,@DIACHI,@SDT)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);
                   
                    cmdInsert.Parameters.Add("@CMND", SqlDbType.VarChar).Value = CMND;
                    cmdInsert.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = NGAYSINH;
                    cmdInsert.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = HOTEN;
                    cmdInsert.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = GIOITINH;
                    cmdInsert.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = DIACHI;
                    cmdInsert.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                  
                }
            }
        }
        //Hàm cập nhật thông tin bệnh nhân 
        public void updateBenhNhan(int MABENHNHAN, string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT)
        {
            string updateInto = "update benhnhan set CMND = @CMND, NGAYSINH =@NGAYSINH, HOTEN = @HOTEN, GT = @GIOITINH, DIACHI = @DIACHI, SDT = @SDT WHERE MABN = @MABENHNHAN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MABENHNHAN", SqlDbType.Int).Value = MABENHNHAN;
                    cmdInsert.Parameters.Add("@CMND", SqlDbType.VarChar).Value = CMND;
                    cmdInsert.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = NGAYSINH;
                    cmdInsert.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = HOTEN;
                    cmdInsert.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = GIOITINH;
                    cmdInsert.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = DIACHI;
                    cmdInsert.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                    
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Hàm xoá thông tin bệnh nhân
        public void deleteBenhNhan(int MABENHNHAN)
        {
            string deleteTable = "delete BENHNHAN where MABN = @MABN";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MABN", SqlDbType.Int).Value = MABENHNHAN;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }

        //Tìm kiếm thông tin bệnh nhân
        public DataSet searchBenhNhan(string CMND)
        {
            DataSet searchResult = new DataSet();
            string searchQuerry = "select * from BENHNHAN where CMND like @CMND";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdSearch = new SqlCommand(searchQuerry, connection);
                cmdSearch.Parameters.Add("@CMND", SqlDbType.VarChar).Value = CMND + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch);
                adapter.Fill(searchResult);
                connection.Close();
            }
            return searchResult;
        }
        public DataSet getHistoryExamByID(int MABENHNHAN)
        {
            DataSet getResult = new DataSet();
            string getQuerry = "select NGAYLAP, NGAYTAIKHAM, NHANVIEN.HOTEN, NHANVIEN.CHUCVU from BENHAN, BENHNHAN,NHANVIEN where BENHNHAN.MABN = @MABENHNHAN AND BENHAN.MANV=1";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdGet = new SqlCommand(getQuerry, connection);
                cmdGet.Parameters.Add("@MABENHNHAN", SqlDbType.Int).Value = MABENHNHAN;
                SqlDataAdapter adapter = new SqlDataAdapter(cmdGet);
                adapter.Fill(getResult);
                connection.Close();
            }
            return getResult;
        }
    }
}
