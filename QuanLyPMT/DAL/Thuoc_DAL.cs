using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class Thuoc_DAL
    {
        //Lấy thông tin thuốc
        public DataSet getDataThuoc()
        {
            DataSet dataThuoc = new DataSet();
            string selectAll = "Select * from LoaiThuoc";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);
                adapter.Fill(dataThuoc);
                connection.Close();
            }
            return dataThuoc;
        }


        // them thuoc

        public void addThuoc (string TENTHUOC,string DONVT,string DUONGDUNG,int TONKHO,float GIANHAP,float GIABAN,string NHACUNGCAP,string GHICHU)
        {
            string insertInto = "INSERT INTO LOAITHUOC VALUES (@TENTHUOC,@DONVT,@DUONGDUNG,@TONKHO,@GHICHU,@GIANHAP,@GIABAN,@NHACUNGCAP)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);
                    cmdInsert.Parameters.Add("@TENTHUOC", SqlDbType.NVarChar).Value = TENTHUOC;
                    cmdInsert.Parameters.Add("@DONVT", SqlDbType.NVarChar).Value = DONVT;
                    cmdInsert.Parameters.Add("@DUONGDUNG", SqlDbType.NVarChar).Value = DUONGDUNG;
                    cmdInsert.Parameters.Add("@TONKHO", SqlDbType.Int).Value = TONKHO;
                    cmdInsert.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = GHICHU;
                    cmdInsert.Parameters.Add("@GIANHAP", SqlDbType.Float).Value = GIANHAP;
                    cmdInsert.Parameters.Add("@GIABAN", SqlDbType.Float).Value = GIABAN;
                    cmdInsert.Parameters.Add("@NHACUNGCAP", SqlDbType.NVarChar).Value = NHACUNGCAP;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception e)
                {
                    
                }
            }
        }

        //Cap nhat thong tin thuoc 
        public void updateThuoc(int MATHUOC,string TENTHUOC, string DONVT, string DUONGDUNG, int TONKHO, float GIANHAP, float GIABAN, string NHACUNGCAP, string GHICHU)
        {
            string updateInto = "update loaithuoc set TENLT=@TENTHUOC,DONVT=@DONVT,DUONGDUNG=@DUONGDUNG,TONKHO=@TONKHO,GHICHU=@GHICHU,GIANHAP=@GIANHAP,GIABAN=@GIABAN,NHACUNGCAP=@NHACUNGCAP WHERE MALT=@MATHUOC";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MATHUOC", SqlDbType.Int).Value = MATHUOC;
                    cmdInsert.Parameters.Add("@TENTHUOC", SqlDbType.NVarChar).Value = TENTHUOC;
                    cmdInsert.Parameters.Add("@DONVT", SqlDbType.NVarChar).Value = DONVT;
                    cmdInsert.Parameters.Add("@DUONGDUNG", SqlDbType.NVarChar).Value = DUONGDUNG;
                    cmdInsert.Parameters.Add("@TONKHO", SqlDbType.Int).Value = TONKHO;
                    cmdInsert.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = GHICHU;
                    cmdInsert.Parameters.Add("@GIANHAP", SqlDbType.Float).Value = GIANHAP;
                    cmdInsert.Parameters.Add("@GIABAN", SqlDbType.Float).Value = GIABAN;
                    cmdInsert.Parameters.Add("@NHACUNGCAP", SqlDbType.NVarChar).Value = NHACUNGCAP;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        //xoa thuoc
        public void deleteThuoc(int MATHUOC)
        {
            string deleteTable = "delete LOAITHUOC where MALT = @MATHUOC";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MATHUOC", SqlDbType.Int).Value = MATHUOC;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                
            }
        }

        //tìm kiếm thuóc
        public DataSet searchThuoc(string TENTHUOC)
        {
            DataSet searchResult = new DataSet();
            string searchQuerry = "select * from LOAITHUOC where TENLT like @TENTHUOC";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdSearch = new SqlCommand(searchQuerry, connection);
                cmdSearch.Parameters.Add("@TENTHUOC", SqlDbType.NVarChar).Value = TENTHUOC + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch);
                adapter.Fill(searchResult);
                connection.Close();
            }
            return searchResult;
        }


    }
}
