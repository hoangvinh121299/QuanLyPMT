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
        
        public DataSet getDataReport(string date)
        {
            DateTime dateTime = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DataSet dataReport = new DataSet();
            string selectData = "SELECT BENHAN.NGAYLAP, BENHNHAN.HOTEN, BENHNHAN.GT, BENHNHAN.NGAYSINH,BENHAN.LOAIBENH, LOAITHUOC.TENLT, LOAITHUOC.GIABAN, CTDONTHUOC.SOLUONG, DONTHUOC.GIATRI " +
                                "FROM DONTHUOC INNER JOIN CTDONTHUOC ON DONTHUOC.MADT = CTDONTHUOC.MADT INNER " +
                                "JOIN LOAITHUOC ON CTDONTHUOC.MALT = LOAITHUOC.MALT CROSS " +
                                "JOIN BENHAN INNER " +
                                "JOIN BENHNHAN ON BENHAN.MABN = BENHNHAN.MABN WHERE BENHAN.NGAYLAP = @NGAYLAP";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(selectData, connection);
                getByID.Parameters.AddWithValue("@NGAYLAP", dateTime);
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(dataReport);
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
                              string GHICHU)
        {
            string insertInto = "INSERT INTO BENHAN VALUES (@NGAYLAP, @NGAYTAIKHAM,@MABN,@MANV,@TIENSUBENH,@TRIEUCHUNG,@LOAIBENH,@CHANDOAN,@HUONGXULY,@GHICHU)";
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
                              string GHICHU)
        {
            string updateInto = "update benhan set NGAYLAP = @NGAYLAP, NGAYTAIKHAM = @NGAYTAIKHAM,MANV = @MANV, TIENSUBENH=@TIENSUBENH,TRIEUCHUNG=@TRIEUCHUNG, LOAIBENH=@LOAIBENH, CHANDOAN = @CHANDOAN, HUONGXULY=@HUONGXULY, GHICHU=@GHICHU WHERE MABA = @MABA";
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

      
        //    public DataSet getHistoryExamByID(int MABENHNHAN)
        //    {
        //        DataSet getResult = new DataSet();
        //        string getQuerry = "select NGAYLAP, NGAYTAIKHAM, NHANVIEN.HOTEN from BENHAN, BENHNHAN,NHANVIEN where BENHNHAN.MABN = @MABENHNHAN AND BENHAN.MANV=1";
        //        using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
        //        {
        //            connection.Open();
        //            SqlCommand cmdGet = new SqlCommand(getQuerry, connection);
        //            cmdGet.Parameters.Add("@MABENHNHAN", SqlDbType.Int).Value = MABENHNHAN;
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmdGet);
        //            adapter.Fill(getResult);
        //            connection.Close();
        //        }
        //        return getResult;
        //    }
        //}
    }
}

