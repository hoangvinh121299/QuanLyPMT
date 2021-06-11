using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class benhAn_DAL
    {

        public DataSet getDataBenhan()
        {
            DataSet dataBenhan = new DataSet();
            string selectAll = "Select * from Benhan";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);
                adapter.Fill(dataBenhan);
                connection.Close();
            }
            return dataBenhan;
        }
        
        public DataSet getDataReport(int MABA)
        {
            DataSet dataReport = new DataSet();
                string selectData = "SELECT BENHAN.NGAYLAP, BENHNHAN.HOTEN, BENHNHAN.GT, BENHNHAN.NGAYSINH,BENHAN.LOAIBENH, LOAITHUOC.TENLT, LOAITHUOC.GIABAN, CTDONTHUOC.SOLUONG, DONTHUOC.GIATRI, BENHAN.TIENKHAM " +
                                    "FROM DONTHUOC INNER JOIN CTDONTHUOC ON DONTHUOC.MADT = CTDONTHUOC.MADT INNER " +
                                    "JOIN LOAITHUOC ON CTDONTHUOC.MALT = LOAITHUOC.MALT RIGHT " +
                                    "JOIN BENHAN INNER " +
                                    "JOIN BENHNHAN ON BENHAN.MABN = BENHNHAN.MABN  ON BENHAN.MABA=DONTHUOC.MABA WHERE BENHAN.MABA= @MABA";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(selectData, connection);
                getByID.Parameters.Add("@MABA", SqlDbType.Int).Value = MABA;
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                    adapter.Fill(dataReport);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                connection.Close();
            }
            return dataReport;
        }

        //Lấy thông tin bệnh án theo MABN
        public DataSet getDataBenhanByID(int MABN)
        {
            DataSet dataBenhanID = new DataSet();
            string selectAll = "Select * from Benhan where MABN = @MABN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(selectAll, connection);
                getByID.Parameters.Add("@MABN", SqlDbType.Int).Value = MABN; 
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(dataBenhanID);
                connection.Close();
            }
            return dataBenhanID;
        }
        //Thêm thông tin bệnh án 
        public void addBenhan(DateTime NGAYLAP,
                              DateTime NGAYTAIKHAM,
                              int MABN,
                              int MANV,
                              string TIENSUBENH,
                              string TRIEUCHUNG,
                              string LOAIBENH,
                              string CHANDOAN,
                              string HUONGXULY,
                              string GHICHU,
                              double TIENKHAM)
        {
            string insertInto = "INSERT INTO BENHAN VALUES (@NGAYLAP, @NGAYTAIKHAM,@MABN,@MANV,@TIENSUBENH,@TRIEUCHUNG,@LOAIBENH,@CHANDOAN,@HUONGXULY,@GHICHU, @TIENKHAM)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = NGAYLAP;
                    cmdInsert.Parameters.Add("@NGAYTAIKHAM", SqlDbType.DateTime).Value = NGAYTAIKHAM;
                    cmdInsert.Parameters.Add("@MABN", SqlDbType.Int).Value = MABN;
                    cmdInsert.Parameters.Add("@MANV", SqlDbType.Int).Value = MANV;
                    cmdInsert.Parameters.Add("@TIENSUBENH", SqlDbType.NVarChar).Value = TIENSUBENH;
                    cmdInsert.Parameters.Add("@TRIEUCHUNG", SqlDbType.NVarChar).Value = TRIEUCHUNG;
                    cmdInsert.Parameters.Add("@LOAIBENH", SqlDbType.NVarChar).Value = LOAIBENH;
                    cmdInsert.Parameters.Add("@CHANDOAN", SqlDbType.NVarChar).Value = CHANDOAN;
                    cmdInsert.Parameters.Add("@HUONGXULY", SqlDbType.NVarChar).Value = HUONGXULY;
                    cmdInsert.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = GHICHU;
                    cmdInsert.Parameters.Add("@TIENKHAM", SqlDbType.Money).Value = TIENKHAM;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }
        }
        //Hàm cập nhật thông tin bệnh án 
        public void updateBenhan(int MABA,
                              DateTime NGAYLAP,
                              DateTime NGAYTAIKHAM,
                             
                              int MANV,
                              string TIENSUBENH,
                              string TRIEUCHUNG,
                              string LOAIBENH,
                              string CHANDOAN,
                              string HUONGXULY,
                              string GHICHU,
                              double TIENKHAM)
        {
            string updateInto = "update benhan set NGAYLAP = @NGAYLAP, NGAYTAIKHAM = @NGAYTAIKHAM,MANV = @MANV, TIENSUBENH=@TIENSUBENH,TRIEUCHUNG=@TRIEUCHUNG, LOAIBENH=@LOAIBENH, CHANDOAN = @CHANDOAN, HUONGXULY=@HUONGXULY, GHICHU=@GHICHU, TIENKHAM= @TIENKHAM WHERE MABA = @MABA";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);

                    cmdInsert.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = NGAYLAP;
                    cmdInsert.Parameters.Add("@NGAYTAIKHAM", SqlDbType.DateTime).Value = NGAYTAIKHAM;
                    cmdInsert.Parameters.Add("@MANV", SqlDbType.Int).Value = MANV;
                    cmdInsert.Parameters.Add("@TIENSUBENH", SqlDbType.NVarChar).Value = TIENSUBENH;
                    cmdInsert.Parameters.Add("@TRIEUCHUNG", SqlDbType.NVarChar).Value = TRIEUCHUNG;
                    cmdInsert.Parameters.Add("@LOAIBENH", SqlDbType.NVarChar).Value = LOAIBENH;
                    cmdInsert.Parameters.Add("@CHANDOAN", SqlDbType.NVarChar).Value = CHANDOAN;
                    cmdInsert.Parameters.Add("@HUONGXULY", SqlDbType.NVarChar).Value = HUONGXULY;
                    cmdInsert.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = GHICHU;
                    cmdInsert.Parameters.Add("@MABA", SqlDbType.Int).Value = MABA;
                    cmdInsert.Parameters.Add("@TIENKHAM", SqlDbType.Money).Value = TIENKHAM;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Hàm xoá thông tin án 
        public void deleteBenhNhan(int MABA)
        {
            string deleteTable = "delete BENHAN where MABA = @MABA";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MABA", SqlDbType.Int).Value = MABA;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }


        public DataSet getExameAmountInDay()
        {
            DataSet getResult = new DataSet();
            string getQuerry = "select ngaylap, sum (tienkham) as doanhthu from benhan group by ngaylap";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdGet = new SqlCommand(getQuerry, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdGet);
                adapter.Fill(getResult);
                connection.Close();
            }
            return getResult;
        }
    }
}


