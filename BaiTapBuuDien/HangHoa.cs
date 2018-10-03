using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapBuuDien
{
    class HangHoa:BuuPham
    {
        public int TrongLuong { get;set }
        public HangHoa()
        { }
        public HangHoa(string maBuuPham, string tenBuuPham, string nguoiNhan, int trongLuong)
                    : base(maBuuPham, tenBuuPham, nguoiNhan)
        {
            TrongLuong = trongLuong;
        }
    }
}
