using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    class Benh_DAL
    {
        public DataSet GetDataSetBenh()
        {
            DataSet datasetBenh = new DataSet();
            string selectAll = "SELECT * FROM LOAIBENH";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectAll, connectionString.GetConnect());
                    dataAdapter.Fill(datasetBenh);
                    connectionString.GetConnect().Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
            return datasetBenh;
        }
        public void AddBenh(DTO.Benh benh)
        {
            string insertInto = "INSERT INTO LOAIBENH (TENBENH, TENLB, TRIEUCHUNG, GHICHU) VALUES(@TENBENH,@TENLB,@TRIEUCHUNG,@GHICHU)";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmdInsert = new SqlCommand(insertInto, connectionString.GetConnect()))
                    {
                        cmdInsert.Parameters.Add("@TENBENH", SqlDbType.NVarChar).Value = benh.TenBenh;
                        cmdInsert.Parameters.Add("@TENLB", SqlDbType.NVarChar).Value = benh.TenLoaiBenh;
                        cmdInsert.Parameters.Add("@TRIEUCHUNG", SqlDbType.NVarChar).Value = benh.TrieuChung;
                        cmdInsert.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = benh.GhiChu;
                        cmdInsert.ExecuteNonQuery();
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
        
        public void UpdateBenh(DTO.Benh benh)
        {
            string insertInto = "UPDATE LOAIBENH SET TENBENH =@TENBENH, TENLB =@TENLOAIBENH, TRIEUCHUNG =@TRIEUCHUNG, GHICHU =@GHICHU " +
                                "WHERE MALB=@MALB";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmdInsert = new SqlCommand(insertInto, connectionString.GetConnect()))
                    {
                        cmdInsert.Parameters.Add("@TENBENH", SqlDbType.NVarChar).Value = benh.TenBenh;
                        cmdInsert.Parameters.Add("@TENLB", SqlDbType.NVarChar).Value = benh.TenLoaiBenh;
                        cmdInsert.Parameters.Add("@TRIEUCHUNG", SqlDbType.NVarChar).Value = benh.TrieuChung;
                        cmdInsert.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = benh.GhiChu;
                        cmdInsert.Parameters.Add("@MALB", SqlDbType.NVarChar).Value = benh.MaLoaiBenh;
                        cmdInsert.ExecuteNonQuery();
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
        public void DeleteBenh(DTO.Benh benh)
        {
            string insertInto = "DELETE FROM LOAIBENH WHERE MALB=@MALB";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmdInsert = new SqlCommand(insertInto, connectionString.GetConnect()))
                    {
                        cmdInsert.Parameters.Add("@MALB", SqlDbType.NVarChar).Value = benh.MaLoaiBenh;
                        cmdInsert.ExecuteNonQuery();
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
    }
   
}
