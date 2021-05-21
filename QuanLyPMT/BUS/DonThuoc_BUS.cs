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

        public DataSet getDataDonThuoc()
        {
            return donThuoc_DAL.getDataDonThuoc();
        }
        public DataSet getDataAll()
        {
            return donThuoc_DAL.getDataAll();
        }
        public DataSet getDataForNametbox()
        {
            return donThuoc_DAL.getDataForNametbox();
        }
        public DataSet getDataDonThuocforBA(int MABA)
        {
            return donThuoc_DAL.getDataDonThuocforBA(MABA);
        }
        public void addDonthuoc(int MABA, DateTime NGAYLAP)
        {
            
        }
    }

}
