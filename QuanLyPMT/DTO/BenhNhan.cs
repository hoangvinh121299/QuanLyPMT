using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class BenhNhan
    {
        

        public int MABENHNHAN { get => mABENHNHAN; set => mABENHNHAN = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public DateTime NGAYSINH { get => nGAYSINH; set => nGAYSINH = value; }
        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public string GIOITINH { get => gIOITINH; set => gIOITINH = value; }
        public string DIACHI { get => dIACHI; set => dIACHI = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string GHICHU { get => gHICHU; set => gHICHU = value; }

        private string gHICHU;
        private string cMND;
        private DateTime nGAYSINH;
        private int mABENHNHAN;
        private string hOTEN;
        private string gIOITINH;
        private string dIACHI;
        private string sDT;
    }
}
