using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Nhanvien
    {
        private int mANV;
        private string hOTEN;
        private string cMND;
        private DateTime nGAYSINH;
        private string gIOITINH;
        private string dIACHI;
        private string sDT;
        private string cHUCVU;

        public int MANV { get => mANV; set => mANV = value; }
        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public DateTime NGAYSINH { get => nGAYSINH; set => nGAYSINH = value; }
        public string GIOITINH { get => gIOITINH; set => gIOITINH = value; }
        public string DIACHI { get => dIACHI; set => dIACHI = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CHUCVU { get => cHUCVU; set => cHUCVU = value; }
    }
}
