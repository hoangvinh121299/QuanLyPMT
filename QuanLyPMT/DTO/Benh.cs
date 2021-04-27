using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Benh
    {
        
        public int MaLoaiBenh { get => maLoaiBenh; set => maLoaiBenh = value; }
        public string TenBenh { get => tenBenh; set => tenBenh = value; }
        public string TenLoaiBenh { get => tenLoaiBenh; set => tenLoaiBenh = value; }
        public string TrieuTrung { get => trieuTrung; set => trieuTrung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        private int maLoaiBenh;
        private string tenBenh;
        private string tenLoaiBenh;
        private string trieuTrung;
        private string ghiChu;

        public Benh() { }
        public Benh(int maLoaiBenh, string tenBenh, string tenLoaiBenh, string trieuTrung, string ghiChu)
        {
            this.maLoaiBenh = maLoaiBenh;
            this.tenBenh = tenBenh;
            this.tenLoaiBenh = tenLoaiBenh;
            this.trieuTrung = trieuTrung;
            this.ghiChu = ghiChu;
            this.maLoaiBenh = maLoaiBenh;
            this.tenBenh = tenBenh;
            this.tenLoaiBenh = tenLoaiBenh;
            this.trieuTrung = trieuTrung;
            this.ghiChu = ghiChu;
        }
    }
}
