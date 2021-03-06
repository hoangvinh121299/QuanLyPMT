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

        public DataSet getDataReport(int MABA)
        {
            return benhAn_DAL.getDataReport(MABA);
        }

        public DataSet getDataByID(int MABN)
        {
            return benhAn_DAL.getDataBenhanByID(MABN);
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
                              string GHICHU, 
                              double TIENKHAM)
        {
            benhAn_DAL.addBenhan(NGAYLAP,NGAYTAIKHAM,MABN,MANV,TIENSUBENH,TRIEUCHUNG,LOAIBENH,CHANDOAN,HUONGXULY,GHICHU,TIENKHAM);
        }
        public void updateBenhAn(int MABA,
                              DateTime NGAYLAP,
                              DateTime NGAYTAIKHAM,
                              int MANV,
                              string TIENSUBENH,
                              string TRIEUCHUNG,
                              string LOAIBENH,
                              string CHANDOAN,
                              string HUONGXULY,
                              string GHICHU, 
                              double TIENKHAM)
        {
            benhAn_DAL.updateBenhan(MABA,NGAYLAP,NGAYTAIKHAM,MANV,TIENSUBENH,TRIEUCHUNG,LOAIBENH,CHANDOAN,HUONGXULY,GHICHU,TIENKHAM);
        }
        public void deleteBenhAn(int MABA)
        {
            benhAn_DAL.deleteBenhNhan(MABA);
        }
        public DataSet getAmountPatience()
        {
            return benhAn_DAL.getAmountOfPatience() ;
        }
        public DataSet getExamAmountInDay()
        {
            return benhAn_DAL.getExameAmountInDay();
        }

    }
}
