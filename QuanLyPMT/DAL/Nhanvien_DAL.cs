﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class Nhanvien_DAL
    {

        public DataSet getDataNhanVien()
        {
            DataSet dataNhanVien = new DataSet();
            string selectAll = "Select * from Nhanvien";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectAll, connection);
                adapter.Fill(dataNhanVien);
                connection.Close();
            }
            return dataNhanVien;
        }

        //Thêm thông tin nhân viên
        public void addNhanvien(string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT,string CHUCVU)
        {
            string insertInto = "INSERT INTO Nhanvien VALUES (@CMND,@NGAYSINH,@HOTEN,@GIOITINH,@DIACHI,@SDT,@CHUCVU)";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(insertInto, connection);

                    cmdInsert.Parameters.Add("@CMND", SqlDbType.VarChar).Value = CMND;
                    cmdInsert.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = NGAYSINH;
                    cmdInsert.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = HOTEN;
                    cmdInsert.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = GIOITINH;
                    cmdInsert.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = DIACHI;
                    cmdInsert.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                    cmdInsert.Parameters.Add("@CHUCVU", SqlDbType.NVarChar).Value = CHUCVU;

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
        public void updateNhanvien(int MANV, string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT,string CHUCVU)
        {
            string updateInto = "update NHANVIEN set CMND = @CMND, NGAYSINH =@NGAYSINH, HOTEN = @HOTEN, GT = @GIOITINH, DIACHI = @DIACHI, SDT = @SDT, CHUCVU = @CHUCVU WHERE MANV = @MANV";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmdSetDateFormat = new SqlCommand("set dateformat dmy", connection);
                    SqlCommand cmdInsert = new SqlCommand(updateInto, connection);
                    cmdInsert.Parameters.Add("@MANV", SqlDbType.Int).Value = MANV;
                    cmdInsert.Parameters.Add("@CMND", SqlDbType.VarChar).Value = CMND;
                    cmdInsert.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = NGAYSINH;
                    cmdInsert.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = HOTEN;
                    cmdInsert.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = GIOITINH;
                    cmdInsert.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = DIACHI;
                    cmdInsert.Parameters.Add("@SDT", SqlDbType.VarChar).Value = SDT;
                    cmdInsert.Parameters.Add("@CHUCVU", SqlDbType.NVarChar).Value = CHUCVU;

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
        public void deleteNhanvien(int MANV)
        {
            string deleteTable = "delete NHANVIEN where MANV = @MANV";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
                {
                    connection.Open();
                    SqlCommand cmdDelete = new SqlCommand(deleteTable, connection);
                    cmdDelete.Parameters.Add("@MANV", SqlDbType.Int).Value = MANV;
                    cmdDelete.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e ) 
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Tìm kiếm thông tin Nhân viên
        public DataSet searchNhanvien(string CMND)
        {
            DataSet searchResult = new DataSet();
            string searchQuerry = "select * from NHANVIEN where CMND like @CMND";
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
        //public DataSet getHistoryExamByID(int MABENHNHAN)
        //{
        //    DataSet getResult = new DataSet();
        //    string getQuerry = "select NGAYLAP, NGAYTAIKHAM, NHANVIEN.HOTEN from BENHAN, BENHNHAN,NHANVIEN where BENHNHAN.MABN = @MABENHNHAN AND BENHAN.MANV=1";
        //    using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))
        //    {
        //        connection.Open();
        //        SqlCommand cmdGet = new SqlCommand(getQuerry, connection);
        //        cmdGet.Parameters.Add("@MABENHNHAN", SqlDbType.Int).Value = MABENHNHAN;
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmdGet);
        //        adapter.Fill(getResult);
        //        connection.Close();
        //    }
        //    return getResult;
        //}
    }
}
