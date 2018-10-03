using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapBuuDien
{
    class Thu:BuuPham
    {
        public bool LoaiThu { get; set; }
        public Thu()
        { }
        public Thu(string maBuuPham, string tenBuuPham, string nguoiNhan,bool loaiThu)
                    :base(maBuuPham,tenBuuPham,nguoiNhan)
        {
            LoaiThu = loaiThu;
        }
    }
}
