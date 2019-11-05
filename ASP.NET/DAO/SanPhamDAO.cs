using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        public static Boolean IsExist(String maSP)
        {
            String query = "SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaSP", maSP);
            return (Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) >= 1);
        }
        public static List<SanPhamDTO> Get()
        {
            List<SanPhamDTO> result = new List<SanPhamDTO>();
            String query = "SELECT * FROM SanPham, LoaiSanPham";
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static List<SanPhamDTO> Get(Boolean trangThai)
        {
            List<SanPhamDTO> result = new List<SanPhamDTO>();
            String query = "SELECT * FROM SanPham WHERE TrangThai = @TrangThai";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TrangThai", trangThai);
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query, param);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static DataTable GetDataTable()
        {
            String query = "SELECT * FROM SanPham, LoaiSanPham WHERE SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP";
            return DataProvider.ExecuteSelectQuery(query);
        }
        public static SanPhamDTO GetObjectByPrimaryKey(String maSP)
        {
            if (IsExist(maSP))
            {
                String query = "SELECT * FROM SanPham WHERE MaSP = @MaSP";
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@MaSP", maSP);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
            }
            return null;
        }
        public static Boolean Insert(SanPhamDTO sanPhamDTO)
        {
            String query = "INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES (@MaSP, @TenSP, @Mau, @KichThuoc, @AnhMinhHoa, @MoTa, @GiaTien, @SoLuongTonKho, @MaLoaiSP, @TrangThai)";
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@MaHD", sanPhamDTO.MaSP);
            param[1] = new SqlParameter("@TenTaiKhoan", sanPhamDTO.TenSP);
            param[2] = new SqlParameter("@NgayMua", sanPhamDTO.Mau);
            param[3] = new SqlParameter("@DiaChiGiaoHang", sanPhamDTO.KichThuoc);
            param[4] = new SqlParameter("@SDTGiaoHang", sanPhamDTO.AnhMinhHoa);
            param[5] = new SqlParameter("@TongTien", sanPhamDTO.MoTa);
            param[6] = new SqlParameter("@TrangThai", sanPhamDTO.GiaTien);
            param[7] = new SqlParameter("@TrangThai", sanPhamDTO.SoLuongTonKho);
            param[8] = new SqlParameter("@TrangThai", sanPhamDTO.MaLoaiSP);
            param[9] = new SqlParameter("@TrangThai", sanPhamDTO.TrangThai);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Update(SanPhamDTO sanPhamDTO)
        {
            String query = "UPDATE SanPham SET TenSP = @TenSP, Mau = @Mau, KichThuoc = @KichThuoc, AnhMinhHoa = @AnhMinhHoa, MoTa = @MoTa, GiaTien = @GiaTien, SoLuongTonKho = @SoLuongTonKho, MaLoaiSP = @MaLoaiSP, TrangThai = @TrangThai WHERE MaSP = @MaSP,";
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@MaHD", sanPhamDTO.MaSP);
            param[1] = new SqlParameter("@TenTaiKhoan", sanPhamDTO.TenSP);
            param[2] = new SqlParameter("@NgayMua", sanPhamDTO.Mau);
            param[3] = new SqlParameter("@DiaChiGiaoHang", sanPhamDTO.KichThuoc);
            param[4] = new SqlParameter("@SDTGiaoHang", sanPhamDTO.AnhMinhHoa);
            param[5] = new SqlParameter("@TongTien", sanPhamDTO.MoTa);
            param[6] = new SqlParameter("@TrangThai", sanPhamDTO.GiaTien);
            param[7] = new SqlParameter("@TrangThai", sanPhamDTO.SoLuongTonKho);
            param[8] = new SqlParameter("@TrangThai", sanPhamDTO.MaLoaiSP);
            param[9] = new SqlParameter("@TrangThai", sanPhamDTO.TrangThai);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Delete(String maSP)
        {
            String query = "UPDATE SanPham SET TrangThai = 0 WHERE MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaSP", maSP);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        private static SanPhamDTO ConvertToDTO(DataRow dr)
        {
            SanPhamDTO result = new SanPhamDTO();
            result.MaSP = Convert.ToString(dr["MaSP"]);
            result.TenSP = Convert.ToString(dr["TenSP"]);
            result.Mau = Convert.ToString(dr["Mau"]);
            result.KichThuoc = Convert.ToInt32(dr["KichThuoc"]);
            result.AnhMinhHoa = Convert.ToString(dr["AnhMinhHoa"]);
            result.MoTa = Convert.ToString(dr["MoTa"]);
            result.GiaTien = Convert.ToInt32(dr["GiaTien"]);
            result.SoLuongTonKho = Convert.ToInt32(dr["SoLuongTonKho"]);
            result.MaLoaiSP = Convert.ToString(dr["MaLoaiSP"]);
            result.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return result;
        }
    }
}
