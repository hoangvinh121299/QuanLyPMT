using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public  class HoatDongTaiKhoan
    {
        private int mATAIKHOAN;
        private DateTime dANGNHAP;
        private DateTime dANGXUAT;
        private TimeSpan tHOILUONG;

        public int MATAIKHOAN { get => mATAIKHOAN; set => mATAIKHOAN = value; }
        public DateTime DANGNHAP { get => dANGNHAP; set => dANGNHAP = value; }
        public DateTime DANGXUAT { get => dANGXUAT; set => dANGXUAT = value; }
        public TimeSpan THOILUONG { get => tHOILUONG; set => tHOILUONG = value; }
    }
}
