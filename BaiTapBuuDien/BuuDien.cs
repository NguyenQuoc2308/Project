using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapBuuDien
{
    class BuuDien
    {
        public string MaBuuDien { get; set; }
        public string TenBuuDien { get; set; }
        public string DiaChi { get; set; }
        public List<BuuPham> DanhSachBuuPham = new List<BuuPham>();
        public BuuDien()
        { }
        public BuuDien(string maBuuDien, string tenBuuDien, string diaChi,
            List<BuuPham> danhSachBuuPham)
        {
            MaBuuDien = maBuuDien;
            TenBuuDien = tenBuuDien;
            DiaChi = diaChi;
            DanhSachBuuPham = danhSachBuuPham;
        }
        public int SoLuongBuuPham()
        {
            return DanhSachBuuPham.Count;
        }
        public int SoLuongHangHoa()
        {
            int soluong = 0;

            foreach(var hanghoa in DanhSachBuuPham)
            {
                if(hanghoa is HangHoa)
                {
                    soluong++;
                }
            }
            return soluong;
        }
        public int SoLuongThu()
        {
            int soluong = 0;
            foreach(var thu in DanhSachBuuPham )
            {
                if(thu is Thu)
                {
                    soluong++;
                }
            }
            return soluong;
        }
        public int SoLuongThuThuong()
        {
            int soluong = 0;
            foreach(var thuthuong in DanhSachBuuPham)
            {
                if(thuthuong is Thu )
                {
                    thuthuong as Thu;
                       
                }
            }
            return soluong;
        }

    }
}
