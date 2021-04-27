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
                    using (SqlCommand cmd = new SqlCommand(insertInto, connectionString.GetConnect()))
                    {

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR:" + e.Message);
                }
            }
        }
    }
   
}
