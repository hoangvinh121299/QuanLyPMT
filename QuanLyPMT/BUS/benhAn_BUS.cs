using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class benhAn_BUS
    {
        benhAn_DAL benhAn_DAL = new benhAn_DAL();

        public DataSet getData()
        {
            return benhAn_DAL.getDataBenhan();
        }
        public void addBenhan
                              (DateTime NGAYLAP,
                              DateTime NGAYTAIKHAM,
                              int MABN,
                              int MANV,
                              string TIENSUBENH,
                              string TRIEUCHUNG,
                              string LOAIBENH,
                              string CHANDOAN,
                              string HUONGXULY,
                              string GHICHU)
        {
            benhAn_DAL.addBenhan(NGAYLAP,NGAYTAIKHAM,MABN,MANV,TIENSUBENH,TRIEUCHUNG,LOAIBENH,CHANDOAN,HUONGXULY,GHICHU);
        }
        public void updateBenhNhan(int MABA,
                              DateTime NGAYLAP,
                              DateTime NGAYTAIKHAM,
                              int MABN,
                              int MANV,
                              string TIENSUBENH,
                              string TRIEUCHUNG,
                              string LOAIBENH,
                              string CHANDOAN,
                              string HUONGXULY,
                              string GHICHU)
        {
            benhAn_DAL.updateBenhan(MABA,NGAYLAP,NGAYTAIKHAM,MABN,MANV,TIENSUBENH,TRIEUCHUNG,LOAIBENH,CHANDOAN,HUONGXULY,GHICHU);
        }
        public void deleteBenhNhan(int MABA)
        {
            benhAn_DAL.deleteBenhNhan(MABA);
        }
        //public DataSet getHistoryExam(int MABENHNHAN)
        //{
        //    return benhNhan_DAL.getHistoryExamByID(MABENHNHAN);
        //}
        //public DataSet searchBenhNhan(string CMND)
        //{
        //    return benhNhan_DAL.searchBenhNhan(CMND);
        //}

    }
}
