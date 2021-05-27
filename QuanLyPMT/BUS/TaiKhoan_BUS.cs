using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
namespace BUS
{
   public  class TaiKhoan_BUS
    {
        TaiKhoan_DAL taikhoan_DAL = new TaiKhoan_DAL();

        DataSet showAllTaiKhoan()
        {
            return taikhoan_DAL.getDataTaikhoan();
        }

        public void addTaiKhoan(string TENDANGNHAP, string MATKHAU, int MANV, int CAPBAC)
        {
            taikhoan_DAL.addTaikhoan(TENDANGNHAP, MATKHAU, MANV, CAPBAC);
        }

        public void updateTaiKhoan(int MATAIKHOAN,string MATKHAU, int CAPBAC)
        {
            taikhoan_DAL.updateTaiKhoan(MATAIKHOAN, MATKHAU, CAPBAC);
        }

        public void deleteTaiKhoan(int MATAIKHOAN)
        {
            taikhoan_DAL.deletETaiKhoan(MATAIKHOAN);
        }

        DataSet searchTaiKhoan(string TENDANGNHAP)
        {
            return taikhoan_DAL.searchTaiKhoan(TENDANGNHAP);
        }

        DataSet getLoginHistory(int MATAIKHOAN)
        {
            return taikhoan_DAL.getHistoryLogin(MATAIKHOAN);
        }
    }
}
