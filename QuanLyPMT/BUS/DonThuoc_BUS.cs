using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class DonThuoc_BUS
    {
        DonThuoc_DAL donThuoc_DAL = new DonThuoc_DAL();

        public DataSet getDataDonThuoc(int MABA)
        {
            return donThuoc_DAL.getDataDonThuoc(MABA);
        }
       
        public DataSet getDataForNametbox()
        {
            return donThuoc_DAL.getDataForNametbox();
        }
   
        public void addDonthuoc(int MABA, DateTime NGAYLAP)
        {
            donThuoc_DAL.addDonthuoc(MABA, NGAYLAP);
        }
        public void addCTdonthuoc(int MADT, int MALT, int SOLUONG, int LIEULUONG)
        {
            donThuoc_DAL.addCTdonthuoc(MADT, MALT, SOLUONG, LIEULUONG);
        }
        public DataSet getMADT(int MABA)
        {
            return donThuoc_DAL.getMADT(MABA);
        }
        public void updateCTdonthuoc(int MALT, int SOLUONG, int LIEUDUNG)
        {
            donThuoc_DAL.updateCTdonthuoc(MALT, SOLUONG, LIEUDUNG);
        }
        public void deletedonthuoc(int MALT)
        {
            donThuoc_DAL.deletedonthuoc(MALT);
        }
        public DataSet getgiatriDT(int MADT)
        {
           return donThuoc_DAL.getgiatriDT(MADT);
        }
        public void updatedonthuoc(int MADT, double GIATRI)
        {
            donThuoc_DAL.updatedonthuoc(MADT, GIATRI);
        }
        public DataSet tinhtonkho(int MADT)
        {
            return donThuoc_DAL.tinhtonkho(MADT);
        }
        public void updatetonkho(int MALT, int TONKHO)
        {
            donThuoc_DAL.updatetonkho(MALT, TONKHO);
        }
        public DataSet gettonkhobyID(int MALT)
        {
            return donThuoc_DAL.gettonkhobyID(MALT);
        }
    }

}
