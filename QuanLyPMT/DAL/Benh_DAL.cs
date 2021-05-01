using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class Benh_DAL
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
        public void AddBenh(Benh benh)
        {
            string insertInto = "INSERT INTO LOAIBENH (TENBENH, TENLB, TRIEUCHUNG, GHICHU) VALUES(@TENBENH,@TENLB,@TRIEUCHUNG,@GHICHU)";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmd = new SqlCommand(insertInto, connectionString.GetConnect()))
                    {
                        cmd.Parameters.Add("@TENBENH", SqlDbType.NVarChar).Value = benh.TenBenh;
                        cmd.Parameters.Add("@TENLB", SqlDbType.NVarChar).Value = benh.TenLoaiBenh;
                        cmd.Parameters.Add("@TRIEUCHUNG", SqlDbType.NVarChar).Value = benh.TrieuChung;
                        cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = benh.GhiChu;
                        cmd.ExecuteNonQuery();
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
        
        public void UpdateBenh(Benh benh)
        {
            string sqlQuerry = "UPDATE LOAIBENH SET TENBENH =@TENBENH, TENLB =@TENLOAIBENH, TRIEUCHUNG =@TRIEUCHUNG, GHICHU =@GHICHU " +
                                "WHERE MALB=@MALB";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuerry, connectionString.GetConnect()))
                    {
                        cmd.Parameters.Add("@TENBENH", SqlDbType.NVarChar).Value = benh.TenBenh;
                        cmd.Parameters.Add("@TENLB", SqlDbType.NVarChar).Value = benh.TenLoaiBenh;
                        cmd.Parameters.Add("@TRIEUCHUNG", SqlDbType.NVarChar).Value = benh.TrieuChung;
                        cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = benh.GhiChu;
                        cmd.Parameters.Add("@MALB", SqlDbType.NVarChar).Value = benh.MaLoaiBenh;
                        cmd.ExecuteNonQuery();
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
        public void DeleteBenh(Benh benh)
        {
            string sqlQuerry = "DELETE FROM LOAIBENH WHERE MALB=@MALB";
            using (connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuerry, connectionString.GetConnect()))
                    {
                        cmd.Parameters.Add("@MALB", SqlDbType.NVarChar).Value = benh.MaLoaiBenh;
                        cmd.ExecuteNonQuery();
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
        public DataSet SearchBenh(String tenBenh)
        {
            DataSet searchResults = new DataSet();
            string sqlQuerry = "SELECT * FROM LOAIBENH WHERE TENBENH=@TENBENH";
            using(connectionString.GetConnect())
            {
                try
                {
                    connectionString.GetConnect().Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuerry, connectionString.GetConnect()))
                    {
                        cmd.Parameters.Add("@TENBENH", SqlDbType.NVarChar).Value = tenBenh;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        dataAdapter.Fill(searchResults);
                    }
                    connectionString.GetConnect().Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
            return searchResults;
        }
    }
   
}
