using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public String MaLoaiSP { get; set; }
        public String TenLoaiSP { get; set; }
        public Boolean TrangThai { get; set; }
        //
        public LoaiSanPhamDTO() { }
        public LoaiSanPhamDTO(String maLoaiSP, String tenLoaiSP, Boolean trangThai = true)
        {
            this.MaLoaiSP = maLoaiSP;
            this.TenLoaiSP = tenLoaiSP;
            this.TrangThai = trangThai;
        }
        public LoaiSanPhamDTO(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            this.MaLoaiSP = loaiSanPhamDTO.MaLoaiSP;
            this.TenLoaiSP = loaiSanPhamDTO.TenLoaiSP;
            this.TrangThai = loaiSanPhamDTO.TrangThai;
        }
    }
}
