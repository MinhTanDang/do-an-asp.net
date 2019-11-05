using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GioHangDTO
    {
        public String TenTaiKhoan { get; set; }
        public String MaSP { get; set; }
        public Int32 SoLuong { get; set; }
        //
        public GioHangDTO() { }
        public GioHangDTO(String tenTaiKhoan, String maSP, Int32 soLuong)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
        }
        public GioHangDTO(GioHangDTO gioHangDTO)
        {
            this.TenTaiKhoan = gioHangDTO.TenTaiKhoan;
            this.MaSP = gioHangDTO.MaSP;
            this.SoLuong = gioHangDTO.SoLuong;
        }
    }
}
