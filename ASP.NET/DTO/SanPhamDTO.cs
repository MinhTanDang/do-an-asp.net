using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public String MaSP { get; set; }
        public String TenSP { get; set; }
        public String Mau { get; set; }
        public Int32 KichThuoc { get; set; }
        public String AnhMinhHoa { get; set; }
        public String MoTa { get; set; }
        public Int32 GiaTien { get; set; }
        public Int32 SoLuongTonKho { get; set; }
        public String MaLoaiSP { get; set; }
        public Boolean TrangThai { get; set; }
        //
        public SanPhamDTO() { }
        public SanPhamDTO(String maSP, String tenSP, String mau, Int32 kichThuoc, String moTa, Int32 giaTien, Int32 soLuongTonKho, String maLoaiSP, Boolean trangThai = true)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Mau = mau;
            this.KichThuoc = kichThuoc;
            this.AnhMinhHoa = String.Empty;
            this.MoTa = moTa;
            this.GiaTien = giaTien;
            this.SoLuongTonKho = soLuongTonKho;
            this.MaLoaiSP = maLoaiSP;
            this.TrangThai = trangThai;
        }
        public SanPhamDTO(String maSP, String tenSP, String mau, Int32 kichThuoc, String anhMinhHoa, String moTa, Int32 giaTien, Int32 soLuongTonKho, String maLoaiSP, Boolean trangThai)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Mau = mau;
            this.KichThuoc = kichThuoc;
            this.AnhMinhHoa = anhMinhHoa;
            this.MoTa = moTa;
            this.GiaTien = giaTien;
            this.SoLuongTonKho = soLuongTonKho;
            this.MaLoaiSP = maLoaiSP;
            this.TrangThai = trangThai;
        }
        public SanPhamDTO(SanPhamDTO sanPhamDTO)
        {
            this.MaSP = sanPhamDTO.MaSP;
            this.TenSP = sanPhamDTO.TenSP;
            this.Mau = sanPhamDTO.Mau;
            this.KichThuoc = sanPhamDTO.KichThuoc;
            this.AnhMinhHoa = sanPhamDTO.AnhMinhHoa;
            this.MoTa = sanPhamDTO.MoTa;
            this.GiaTien = sanPhamDTO.GiaTien;
            this.SoLuongTonKho = sanPhamDTO.SoLuongTonKho;
            this.MaLoaiSP = sanPhamDTO.MaLoaiSP;
            this.TrangThai = sanPhamDTO.TrangThai;
        }
    }
}
