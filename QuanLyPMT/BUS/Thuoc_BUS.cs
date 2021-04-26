using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;
namespace BUS
{
    public class Thuoc_BUS
    {
        Thuoc_DAL thuoc_DAL = new Thuoc_DAL();

        public DataSet getData()
        {
            return thuoc_DAL.getDataThuoc();
        }
        public void addThuoc(string TENTHUOC, string DONVT, string DUONGDUNG, int TONKHO, float GIANHAP, float GIABAN, string NHACUNGCAP, string GHICHU)
        {
            thuoc_DAL.addThuoc(TENTHUOC, DONVT, DUONGDUNG, TONKHO, GIANHAP, GIABAN, NHACUNGCAP, GHICHU);
        }
        public void updateThuoc(int MATHUOC, string TENTHUOC, string DONVT, string DUONGDUNG, int TONKHO, float GIANHAP, float GIABAN, string NHACUNGCAP, string GHICHU)
        {
            thuoc_DAL.updateThuoc(MATHUOC, TENTHUOC, DONVT, DUONGDUNG, TONKHO, GIANHAP, GIABAN, NHACUNGCAP, GHICHU);
        }
        public void deleteThuoc(int MATHUOC)
        {
            thuoc_DAL.deleteThuoc(MATHUOC);
        }
        public DataSet searchThuoc(string TENTHUOC)
        {
            return thuoc_DAL.searchThuoc(TENTHUOC);
        }
    }
}
