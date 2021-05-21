using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class DonThuoc_DAL
    {
        public DataSet getDataDonThuoc()
        {
            DataSet datadonthuoc = new DataSet();
            string sql = "select * from Donthuoc";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datadonthuoc);
                connection.Close();
            }
            return datadonthuoc;
        }
        public DataSet getDataAll()
        {
            DataSet datadonthuoc = new DataSet();
            string sql = "select  * from donthuoc dt  inner join CTDONTHUOC ct  on dt.madt = ct.MADT inner join LOAITHUOC lt on ct.MALT = lt.MALT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datadonthuoc);
                connection.Close();
            }
            return datadonthuoc;
        }
        public DataSet getDataForNametbox()
        {
            DataSet datadonthuoc = new DataSet();
            string sql = "select  malt,tenlt from LOAITHUOC";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(datadonthuoc);
                connection.Close();
            }
            return datadonthuoc;
        }

        public DataSet getDataDonThuocforBA(int MABA)
        {
            DataSet datadonthuocforBA = new DataSet();
            string sql = "select * from Donthuoc where MABA=@MABA ";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(sql, connection);
                getByID.Parameters.Add("@MABA", SqlDbType.Int).Value = MABA;
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(datadonthuocforBA);
                connection.Close();
            }
            return datadonthuocforBA;
        }
        public void addDonthuoc (int MABA, DateTime NGAYLAP)
        {
            string insertInto = "INSERT INTO DONTHUOC VALUES (@NGAYLAP,@GIATRI,@MABN)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = NGAYLAP;
                    cmdInsert.Parameters.Add("@GIATRI", SqlDbType.DateTime).Value = 0;
                    cmdInsert.Parameters.Add("@MABN", SqlDbType.Int).Value = MABA;

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
