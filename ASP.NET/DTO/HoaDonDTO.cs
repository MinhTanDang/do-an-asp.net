using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public String MaHD { get; set; }
        public String TenTaiKhoan { get; set; }
        public DateTime NgayMua { get; set; }
        public String DiaChiGiaoHang { get; set; }
        public String SDTGiaoHang { get; set; }
        public Int32 TongTien { get; set; }
        public Boolean TrangThai { get; set; }
        //
        public HoaDonDTO() { }
        public HoaDonDTO(String maHD, String tenTaiKhoan, DateTime ngayMua, String diaChiGiaoHang, String sdtGiaoHang, Int32 tongTien, Boolean trangThai = true)
        {
            this.MaHD = maHD;
            this.TenTaiKhoan = tenTaiKhoan;
            this.NgayMua = ngayMua;
            this.DiaChiGiaoHang = diaChiGiaoHang;
            this.SDTGiaoHang = sdtGiaoHang;
            this.TongTien = tongTien;
            this.TrangThai = trangThai;
        }
        public HoaDonDTO(HoaDonDTO hoaDonDTO)
        {
            this.MaHD = hoaDonDTO.MaHD;
            this.TenTaiKhoan = hoaDonDTO.TenTaiKhoan;
            this.NgayMua = hoaDonDTO.NgayMua;
            this.DiaChiGiaoHang = hoaDonDTO.DiaChiGiaoHang;
            this.SDTGiaoHang = hoaDonDTO.SDTGiaoHang;
            this.TongTien = hoaDonDTO.TongTien;
            this.TrangThai = hoaDonDTO.TrangThai;
        }
    }
}
