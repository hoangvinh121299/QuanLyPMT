using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
namespace BUS
{
    public class HoatDongTaiKhoan_BUS
    {
        HoatDongTaiKhoan_DAL hoatdongtaikhoan_DAL = new HoatDongTaiKhoan_DAL();
        public DataSet getHistoryLogin(int MATAIKHOAN)
        {
            return hoatdongtaikhoan_DAL.getHistoryByMaTaiKhoan(MATAIKHOAN);
        }

        public void insertHoatDong(int MATAIKHOAN, DateTime DANGNHAP, DateTime DANGXUAT, TimeSpan THOILUONG)
        {
            hoatdongtaikhoan_DAL.addHoatDongTaiKhoan(MATAIKHOAN, DANGNHAP, DANGXUAT, THOILUONG);
        }
    }
}
