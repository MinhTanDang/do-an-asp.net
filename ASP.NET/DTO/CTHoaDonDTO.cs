using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDonDTO
    {
        public String MaHD { get; set; }
        public String MaSP { get; set; }
        public Int32 SoLuong { get; set; }
        public Int32 DonGia { get; set; }
        //
        public CTHoaDonDTO() { }
        public CTHoaDonDTO(String maHD, String maSP, Int32 soLuong, Int32 donGia)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }
        public CTHoaDonDTO(CTHoaDonDTO ctHoaDonDTO)
        {
            this.MaHD = ctHoaDonDTO.MaHD;
            this.MaSP = ctHoaDonDTO.MaSP;
            this.SoLuong = ctHoaDonDTO.SoLuong;
            this.DonGia = ctHoaDonDTO.DonGia;
        }
    }
}
