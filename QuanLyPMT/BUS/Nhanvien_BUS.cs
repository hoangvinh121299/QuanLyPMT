using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
namespace BUS
{
    public class Nhanvien_BUS
    {
        Nhanvien_DAL nhanvien_DAL= new Nhanvien_DAL(); 
        public DataSet getDataNhanVien()
        {
            return nhanvien_DAL.getDataNhanVien();
        }

        public void addNhanvien(string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT,string CHUCVU)
        {
            nhanvien_DAL.addNhanvien(CMND, NGAYSINH, HOTEN, GIOITINH, DIACHI, SDT,CHUCVU);
        }
        public void updateNhanvien(int MANV, string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT,string CHUCVU)
        {
            nhanvien_DAL.updateNhanvien(MANV, CMND, NGAYSINH, HOTEN, GIOITINH, DIACHI, SDT, CHUCVU);
        }
        public void deleteNhanvien(int MANV)
        {
            nhanvien_DAL.deleteNhanvien(MANV);
        }
        public DataSet getHistoryWork(int MANV)
        {
            return nhanvien_DAL.getHistoryWorkByID(MANV);
        }
        public DataSet searchNV(string CMND)
        {
            return nhanvien_DAL.searchNhanvien(CMND);
        }

        public DataSet getData()
        {
            return nhanvien_DAL.getNameNhanVien();
        }

        public DataSet getNameByLikeLy(string HOTEN)
        {
            return nhanvien_DAL.getLikeLyNameNhanvien(HOTEN);
        }
        public DataSet getDateNhanVienByMANV(int MANV)
        {
            return nhanvien_DAL.getNhanVienByMANV(MANV);
        }
    }
}
