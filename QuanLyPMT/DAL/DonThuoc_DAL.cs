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
        public DataSet getDataDonThuoc(int MABA)
        {
            DataSet datadonthuoc = new DataSet();
            string sql = "select dt.MADT,lt.MALT,lt.TENLT,ct.SOLUONG,ct.LIEUDUNG,dt.NGAYLAP,dt.GIATRI  from LOAITHUOC lt,CTDONTHUOC ct,DONTHUOC dt where lt.MALT=ct.MALT and dt.MADT = ct.MADT and dt.MABA=@MABA";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(sql, connection);
                getByID.Parameters.Add("@MABA", SqlDbType.Int).Value = MABA;
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
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

        public DataSet getMADT(int MABA)
        {
            DataSet dataMADT = new DataSet();
            string sql = "select  MADT from DONTHUOC where MABA=@MABA";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(sql, connection);
                getByID.Parameters.Add("@MABA", SqlDbType.Int).Value = MABA;
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(dataMADT);
                connection.Close();
            }
            return dataMADT;
        }

        public void addDonthuoc (int MABA, DateTime NGAYLAP)
        {
            string insertInto = "INSERT INTO DONTHUOC VALUES (@NGAYLAP,@GIATRI,@MABA)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@NGAYLAP", SqlDbType.DateTime).Value = NGAYLAP;
                    cmdInsert.Parameters.Add("@GIATRI", SqlDbType.Money).Value = 0;
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

        public void addCTdonthuoc(int MADT,int MALT,int SOLUONG,int LIEULUONG)
        {
            string insertInto = "INSERT INTO CTDONTHUOC VALUES (@MADT,@MALT,@SOLUONG,@LIEULUONG)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@MADT", SqlDbType.Int).Value = MADT;
                    cmdInsert.Parameters.Add("@MALT", SqlDbType.Int).Value = MALT;
                    cmdInsert.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = SOLUONG;
                    cmdInsert.Parameters.Add("@LIEULUONG", SqlDbType.Int).Value = LIEULUONG;

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void updateCTdonthuoc(int MALT,int SOLUONG,int LIEUDUNG)
        {
            string updateInto = "update ctdonthuoc set SOLUONG=@SOLUONG,LIEUDUNG=@LIEUDUNG WHERE MALT=@MALT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MALT", SqlDbType.Int).Value = MALT;
                    cmdInsert.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = SOLUONG;
                    cmdInsert.Parameters.Add("@LIEUDUNG", SqlDbType.Int).Value = LIEUDUNG;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void updatedonthuoc(int MADT,double GIATRI)
        {
            string updateInto = "update donthuoc set GIATRI=@GIATRI WHERE MADT=@MADT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MADT", SqlDbType.Int).Value = MADT;
                    cmdInsert.Parameters.Add("@GIATRI", SqlDbType.Money).Value = GIATRI;
                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        public void deletedonthuoc(int MALT)
        {
            string deleteTable = "delete ctdonthuoc where MALT = @MALT";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MALT", SqlDbType.Int).Value = MALT;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }
        public DataSet getgiatriDT(int MADT)
        {
            DataSet giatriDT = new DataSet();
            string sql = "select lt.giaban,ct.SOLUONG from  LOAITHUOC lt join CTDONTHUOC ct on lt.MALT = ct.MALT where ct.MADT=@MADT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(sql, connection);
                getByID.Parameters.Add("@MADT", SqlDbType.Int).Value = MADT;
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(giatriDT);
                connection.Close();
            }
            return giatriDT;
        }
        public DataSet tinhtonkho(int MADT)
        {
            DataSet thuoctonkho = new DataSet();
            string sql = "select lt.MALT, lt.TONKHO , ct.SOLUONG from LOAITHUOC lt join CTDONTHUOC ct on lt.MALT=ct.MALT where ct.MADT=@MADT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(sql, connection);
                getByID.Parameters.Add("@MADT", SqlDbType.Int).Value = MADT;
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(thuoctonkho);
                connection.Close();
            }
            return thuoctonkho;
        }

        public DataSet gettonkhobyID (int MALT)
        {
            DataSet thuoctonkho = new DataSet();
            string sql = "select TONKHO from LOAITHUOC where ct.MALT=@MALT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand getByID = new SqlCommand(sql, connection);
                getByID.Parameters.Add("@MALT", SqlDbType.Int).Value = MALT;
                SqlDataAdapter adapter = new SqlDataAdapter(getByID);
                adapter.Fill(thuoctonkho);
                connection.Close();
            }
            return thuoctonkho;
        }
        public void updatetonkho(int MALT,int TONKHO)
        {
            string updateInto = "update loaithuoc set TONKHO=@TONKHO WHERE MALT=@MALT";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MALT", SqlDbType.Int).Value = MALT;
                    cmdInsert.Parameters.Add("@TONKHO", SqlDbType.Money).Value = TONKHO;
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
