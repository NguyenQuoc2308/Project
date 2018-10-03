using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapBuuDien
{
    abstract class BuuPham
    {
        public string MaBuuPham { get; set; }
        public string TenBuuPham { get; set; }
        public string NguoiNhan { get; set; }
        public BuuPham()
        {

        }
        public BuuPham(string maBuuPham,string tenBuuPham,string nguoiNhan)
        {
            MaBuuPham = maBuuPham;
            TenBuuPham = tenBuuPham;
            NguoiNhan = nguoiNhan;
        }

    }
}
