using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class TaiKhoan_DAL
    {
        List<TaiKhoan> listTaiKhoan = new List<TaiKhoan>();
        public DataSet getDataTaikhoan()
        {
            DataSet dataTaiKhoan = new DataSet();
            string selectAll = "select nhanvien.hoten,mataikhoan, tendangnhap, matkhau, capbac from taikhoan, nhanvien where taikhoan.manv = nhanvien.manv";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);
                adapter.Fill(dataTaiKhoan);
                connection.Close();
            }
            return dataTaiKhoan;
        }
        //Lấy thông tin gần đúng của theo tên truyền vào
        public void getDataAccount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                string get = "SELECT * FROM TAIKHOAN";
                SqlCommand sqlcommand = new SqlCommand(get, connection);

                SqlDataReader dataReader = sqlcommand.ExecuteReader();
                while(dataReader.Read())
                {
                    TaiKhoan taikhoan = new TaiKhoan();
                    taikhoan.MATAIKHOAN = (int)dataReader["MATAIKHOAN"];
                    taikhoan.TENDANGNHAP = (string)dataReader["TENDANGNHAP"];
                    taikhoan.MATKHAU = (string)dataReader["MATKHAU"];
                    taikhoan.MANV = (int)dataReader["MANV"];
                    taikhoan.CAPBAC = (int)dataReader["CAPBAC"];

                    listTaiKhoan.Add(taikhoan);
                }
                connection.Close();
            }
        }
        public bool validateTaiKhoan(string TENDANGNHAP, string MATKHAU)
        {
            //TaiKhoan input = new TaiKhoan();
            getDataAccount();
            foreach(var temp in listTaiKhoan)
            {
                if (temp.TENDANGNHAP == TENDANGNHAP && checkPass(MATKHAU, temp.MATKHAU))
                    return true;
            }
            return false;
        }
        public TaiKhoan getDataAccountLogin(string TENDANGNHAP, string MATKHAU)
        {
            TaiKhoan output = new TaiKhoan();
            foreach(var temp in listTaiKhoan)
            {
                if (temp.TENDANGNHAP == TENDANGNHAP && checkPass(MATKHAU, temp.MATKHAU))
                    output = temp;
            }
            return output;
        }
        public DataSet searchTaiKhoanByTen(string HOTEN)
        {
            DataSet result = new DataSet();
            string selectAll = "select nhanvien.hoten,mataikhoan, tendangnhap, matkhau, capbac from taikhoan, nhanvien where taikhoan.manv = nhanvien.manv and nhanvien.hoten like @HOTEN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand search = new SqlCommand(selectAll, connection);
                search.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = HOTEN + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(search);
                adapter.Fill(result);
                connection.Close();
            }
            return result;
        }
        //Lấy thông tin của một nhân viên bất kỳ 
        public DataSet getPersonAccount(int MANV)
        {
            DataSet personData = new DataSet();
            string select = "select nhanvien.hoten, tendangnhap, matkhau, capbac from taikhoan, nhanvien where taikhoan.manv = @MANV";
            using(SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(select, connection);
                adapter.Fill(personData);
                connection.Close();
            }
            return personData;
        }
        //Thêm thông tin tài khoản 
        public void addTaikhoan(string TENDANGNHAP, string MATKHAU,int MANV, int CAPBAC)
        {
            string insertInto = "INSERT INTO TAIKHOAN VALUES (@TENDANGNHAP, @MATKHAU, @MANV,@CAPBAC)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar).Value = TENDANGNHAP;
                    cmdInsert.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = MATKHAU;
                    cmdInsert.Parameters.Add("@MANV", SqlDbType.Int).Value = MANV;
                    cmdInsert.Parameters.Add("@CAPBAC", SqlDbType.Int).Value = CAPBAC;
                    

                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }
        }
        //Hàm cập nhật thông tin Nhân viên 
        public void updateTaiKhoan(int MATAIKHOAN,string MATKHAU,int CAPBAC)
        {
            string updateInto = "update TAIKHOAN set MATKHAU= @MATKHAU, CAPBAC = @CAPBAC WHERE MATAIKHOAN = @MATAIKHOAN" ;
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                    cmdInsert.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = MATKHAU;
                    cmdInsert.Parameters.Add("@CAPBAC", SqlDbType.Int).Value = CAPBAC;


                    cmdInsert.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }
        //Hàm xoá thông tin Nhân vi
        public void deletETaiKhoan(int MATAIKHOAN)
        {
            string deleteTable = "delete TAIKHOAN where MATAIKHOAN = @MATAIKHOAN";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Tìm kiếm thông tin Nhân viên
        public DataSet searchTaiKhoan(string TEMDANGNHAP)
        {
            DataSet searchResult = new DataSet();
            string searchQuerry = "select * from TaiKhoan where TENDANGNHAP like @TENDANGNHAP";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdSearch = new SqlCommand(searchQuerry, connection);
                cmdSearch.Parameters.Add("@TENDANGNHAP", SqlDbType.VarChar).Value = TEMDANGNHAP + "%";
                SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch);
                adapter.Fill(searchResult);
                connection.Close();
            }
            return searchResult;
        }
        public DataSet getHistoryLogin(int MATAIKHOAN)
        {
            DataSet getResult = new DataSet();
            string getQuerry = "select DANGNHAP, DANGXUAT, THOILUONG from TAIKHOAN, HOATDONGTAIKHOAN where HOATDONGTAIKHOAN.MATAIKHOAN = @MATAIKHOAN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdGet = new SqlCommand(getQuerry, connection);
                cmdGet.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN;
                SqlDataAdapter adapter = new SqlDataAdapter(cmdGet);
                adapter.Fill(getResult);
                connection.Close();
            }
            return getResult;
        }
        public DataSet getTaiKhoanByMATK(int MATAIKHOAN)
        {
            DataSet get = new DataSet();
            string searchQuerry = "select nhanvien.hoten,mataikhoan, tendangnhap, matkhau, capbac from taikhoan, nhanvien where taikhoan.manv = nhanvien.manv and taikhoan.mataikhoan = @MATAIKHOAN";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmdSearch = new SqlCommand(searchQuerry, connection);
                cmdSearch.Parameters.Add("@MATAIKHOAN", SqlDbType.Int).Value = MATAIKHOAN ;
                SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch); 
                adapter.Fill(get);
                connection.Close();
            }
            return get;
        }
        private bool checkPass(string enterPassword, string savedPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.EnhancedVerify(enterPassword, savedPassword);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
