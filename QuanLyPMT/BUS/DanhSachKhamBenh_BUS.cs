using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
namespace BUS
{
    public class DanhSachKhamBenh_BUS
    {
        DanhSachKhamBenh_DAL danhsachkhambenh_DAL = new DanhSachKhamBenh_DAL();
        public DataSet getDanhSachBenhNhanInDay()
        {
            return danhsachkhambenh_DAL.GetDataDanhSachKhamBenhInDay();
        }

        public void AddBenhNhanToDanhSach(int MABN)
        {
            danhsachkhambenh_DAL.AddBenhNhanToDanhSach(MABN);
        }
    }
}
