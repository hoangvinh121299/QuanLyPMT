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
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        private int maLoaiBenh;
        private string tenBenh;
        private string tenLoaiBenh;
        private string trieuChung;
        private string ghiChu;

        public Benh() { }
        public Benh(string tenBenh, string tenLoaiBenh, string trieuTrung, string ghiChu, int maLoaiBenh = 0)
        {
            this.maLoaiBenh = maLoaiBenh;
            this.tenBenh = tenBenh;
            this.tenLoaiBenh = tenLoaiBenh;
            this.trieuChung = trieuTrung;
            this.ghiChu = ghiChu;
            this.maLoaiBenh = maLoaiBenh;
            this.tenBenh = tenBenh;
            this.tenLoaiBenh = tenLoaiBenh;
            this.trieuChung = trieuTrung;
            this.ghiChu = ghiChu;
        }
    }
}
