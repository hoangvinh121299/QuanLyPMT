using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BenhAN
    {
        private int mABA;
        private DateTime nGAYLAP;
        private DateTime nGAYTAIKHAM;
        private int mABN;
        private int mANV;
        private string tIENSUBENH;
        private string tRIEUCHUNG;
        private string lOAIBENH;
        private string cHANDOAN;
        private string hUONGXULY;
        private string gHICHU;
        private string hOTEN;

        private double tIENKHAM;
        public int MABA { get => mABA; set => mABA = value; }
        public DateTime NGAYLAP { get => nGAYLAP; set => nGAYLAP = value; }
        public DateTime NGAYTAIKHAM { get => nGAYTAIKHAM; set => nGAYTAIKHAM = value; }
        public int MABN { get => mABN; set => mABN = value; }
        public int MANV { get => mANV; set => mANV = value; }
        public string TIENSUBENH { get => tIENSUBENH; set => tIENSUBENH = value; }
        public string TRIEUCHUNG { get => tRIEUCHUNG; set => tRIEUCHUNG = value; }
        public string LOAIBENH { get => lOAIBENH; set => lOAIBENH = value; }
        public string CHANDOAN { get => cHANDOAN; set => cHANDOAN = value; }
        public string HUONGXULY { get => hUONGXULY; set => hUONGXULY = value; }
        public string GHICHU { get => gHICHU; set => gHICHU = value; }
        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public double TIENKHAM { get => tIENKHAM; set => tIENKHAM = value; }
    }
}
