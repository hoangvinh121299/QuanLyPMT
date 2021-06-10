using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DAL
{
    public class DanhSachKhamBenh_DAL
    {
        public DataSet GetDataDanhSachKhamBenhInDay()
        {
            DataSet datasetBenh = new DataSet();
            string selectAll = "select  benhnhan.mabn, benhnhan.hoten, benhnhan.GT,benhnhan.CMND from benhnhan, danhsachkhambenh where DANHSACHKHAMBENH.MABN = BENHNHAN.MABN and convert(varchar(10), danhsachkhambenh.ngaykham, 102) = convert(varchar(10), getdate(), 102)";
            using (SqlConnection sqlConnection = connectionString.GetConnect())
            {
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectAll, sqlConnection);
                    dataAdapter.Fill(datasetBenh);
                    sqlConnection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
            return datasetBenh;
        }

        public void AddBenhNhanToDanhSach(int MABN)
        {
            string addData = "insert into danhsachkhambenh values (@MABN, GETDATE())";
            using (SqlConnection connection = connectionString.GetConnect())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(addData, connection);

                    cmdInsert.Parameters.Add("@MABN", SqlDbType.Int).Value = MABN;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Đăng ký khám thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }

        }
        public void DeleteBenhNhanFromDanhSach(int MABN)
        {
            string deleteQuerry = "delete  from danhsachkhambenh where MABN = @MABN";
            using (SqlConnection connection = connectionString.GetConnect())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteQuerry, connection);
                    cmdDelete.Parameters.Add("@MABN", SqlDbType.Int).Value = MABN;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Tìm kiếm thông tin bệnh nhân trong danh sách khám bệnh
        public DataSet searchBenhNhanFromDanhSach(string CMND)
        {
            DataSet searchResult = new DataSet();
            string searchQuerry = "select  benhnhan.mabn, benhnhan.hoten, benhnhan.GT,benhnhan.CMND from benhnhan, danhsachkhambenh where danhsachkhambenh.mabn = BENHNHAN.MABN and convert(varchar(10), danhsachkhambenh.ngaykham, 102) = convert(varchar(10), getdate(), 102) and benhnhan.CMND like @CMND";
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
    }
}