using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TaiKhoan
    {
        private int mATAIKHOAN;
        private string tENDANGNHAP;
        private string mATKHAU;
        private int mANV;
        private int cAPBAC;

        public int MATAIKHOAN { get => mATAIKHOAN; set => mATAIKHOAN = value; }
        public string TENDANGNHAP { get => tENDANGNHAP; set => tENDANGNHAP = value; }
        public string MATKHAU { get => mATKHAU; set => mATKHAU = value; }
        public int MANV { get => mANV; set => mANV = value; }
        public int CAPBAC { get => cAPBAC; set => cAPBAC = value; }
    }
}
