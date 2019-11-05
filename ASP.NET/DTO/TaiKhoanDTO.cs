using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public String TenTaiKhoan { get; set; }
        public String MatKhau { get; set; }
        public String HoTen { get; set; }
        public String Email { get; set; }
        public String SDT { get; set; }
        public String DiaChi { get; set; }
        public String AnhDaiDien { get; set; }
        public Boolean LaAdmin { get; set; }
        public Boolean TrangThai { get; set; }
        //
        public TaiKhoanDTO() { }
        public TaiKhoanDTO(String tenTaiKhoan, String matKhau, String hoTen, String email, String sdt, String diaChi, String anhDaiDien, Boolean laAdmin = false, Boolean trangThai = true)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.HoTen = hoTen;
            this.Email = email;
            this.SDT = sdt;
            this.DiaChi = diaChi;
            this.AnhDaiDien = anhDaiDien;
            this.LaAdmin = laAdmin;
            this.TrangThai = trangThai;
        }
        public TaiKhoanDTO(String tenTaiKhoan, String matKhau, String hoTen, String email, String sdt, String diaChi)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.HoTen = hoTen;
            this.Email = email;
            this.SDT = sdt;
            this.DiaChi = diaChi;
            this.AnhDaiDien = String.Empty;
            this.LaAdmin = false;
            this.TrangThai = true;
        }
        public TaiKhoanDTO(TaiKhoanDTO taiKhoanDTO)
        {
            this.TenTaiKhoan = taiKhoanDTO.TenTaiKhoan;
            this.MatKhau = taiKhoanDTO.MatKhau;
            this.HoTen = taiKhoanDTO.HoTen;
            this.Email = taiKhoanDTO.Email;
            this.SDT = taiKhoanDTO.SDT;
            this.DiaChi = taiKhoanDTO.DiaChi;
            this.AnhDaiDien = taiKhoanDTO.AnhDaiDien;
            this.LaAdmin = taiKhoanDTO.LaAdmin;
            this.TrangThai = taiKhoanDTO.TrangThai;
        }
    }
}
