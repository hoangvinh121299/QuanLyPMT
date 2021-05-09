using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class BenhNhan_BUS
    {
        BenhNhan_DAL benhNhan_DAL = new BenhNhan_DAL();

        public DataSet getData()
        {
            return benhNhan_DAL.getDataBenhNhan();
        }
        public void addBenhNhan(string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT)
        {
            benhNhan_DAL.addBenhNhan(CMND, NGAYSINH, HOTEN, GIOITINH, DIACHI, SDT);
        }
        public void updateBenhNhan(int MABENHNHAN, string CMND, DateTime NGAYSINH, string HOTEN, string GIOITINH, string DIACHI, string SDT)
        {
            benhNhan_DAL.updateBenhNhan(MABENHNHAN, CMND, NGAYSINH, HOTEN, GIOITINH, DIACHI, SDT);
        }
        public void deleteBenhNhan(int MABENHNHAN)
        {
            benhNhan_DAL.deleteBenhNhan(MABENHNHAN);
        }
        public DataSet getHistoryExam(int MABENHNHAN)
        {
            return benhNhan_DAL.getHistoryExamByID(MABENHNHAN);
        }
        public DataSet searchBenhNhan(string CMND)
        {
            return benhNhan_DAL.searchBenhNhan(CMND);
        }
        
    }
}
