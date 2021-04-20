using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Thuoc
    {
        private int maTHUOC;
        private string tenTHUOC;
        private string donVT;
        private string duongDUNG;
        private int tonKHO;
        private float giaNHAP;
        private float giaBAN;
        private string nhaCUNGCAP;
        private string ghiCHU;
        public int MATHUOC { get => maTHUOC; set => maTHUOC = value; }
        public string TENTHUOC { get => tenTHUOC; set => tenTHUOC = value; }
        public string DONVT { get => donVT; set => donVT = value; }
        public string DUONGDUNG { get => duongDUNG; set => duongDUNG = value; }
        public int TONKHO { get => tonKHO; set => tonKHO = value; }
        public float GIANHAP { get => giaNHAP; set => giaNHAP = value; }
        public float GIABAN { get => giaBAN; set => giaBAN = value; }
        public string NHACUNGCAP { get => nhaCUNGCAP; set => nhaCUNGCAP = value; }
        public string GHICHU { get => ghiCHU; set => ghiCHU = value; }
    }
}
