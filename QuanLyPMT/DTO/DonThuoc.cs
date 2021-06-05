using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DonThuoc
    {
        private int maDT;
        private int maLT;
        private int maBA;
        private DateTime ngayTao;
        private double giaTri;
        private int soLuong;
        private int lieuDung;
        private string tenLT;

        public int MaDT { get => maDT; set => maDT = value; }
        public int MaLT { get => maLT; set => maLT = value; }
        public int MaBA { get => maBA; set => maBA = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public double GiaTri { get => giaTri; set => giaTri = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int LieuDung { get => lieuDung; set => lieuDung = value; }
        public string TenLT { get => tenLT; set => tenLT = value; }
    }
}
