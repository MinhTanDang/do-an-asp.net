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
    public class HoaDonDAO
    {
        public static Boolean IsExist(String maHD)
        {
            String query = "SELECT COUNT(*) FROM HoaDon WHERE MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaHD", maHD);
            return (Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) >= 1);
        }
        public static List<HoaDonDTO> Get()
        {
            List<HoaDonDTO> result = new List<HoaDonDTO>();
            String query = "SELECT * FROM HoaDon";
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static List<HoaDonDTO> Get(Boolean trangThai)
        {
            List<HoaDonDTO> result = new List<HoaDonDTO>();
            String query = "SELECT * FROM HoaDon WHERE TrangThai = @TrangThai";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TrangThai", trangThai);
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query, param);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static HoaDonDTO GetObjectByPrimaryKey(String maHD)
        {
            if(IsExist(maHD))
            {
                String query = "SELECT * FROM HoaDon WHERE MaHD = @MaHD";
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@MaHD", maHD);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
            }
            return null;
        }
        public static Boolean Insert(HoaDonDTO hoaDonDTO)
        {
            String query = "INSERT INTO HoaDon (MaHD, TenTaiKhoan, NgayMua, DiaChiGiaoHang, SDTGiaoHang, TongTien, TrangThai) VALUES (@MaHD, @TenTaiKhoan, @NgayMua, @DiaChiGiaoHang, @SDTGiaoHang, @TongTien, @TrangThai)";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@MaHD", hoaDonDTO.MaHD);
            param[1] = new SqlParameter("@TenTaiKhoan", hoaDonDTO.TenTaiKhoan);
            param[2] = new SqlParameter("@NgayMua", hoaDonDTO.NgayMua.ToString("MM-dd-yyyy"));
            param[3] = new SqlParameter("@DiaChiGiaoHang", hoaDonDTO.DiaChiGiaoHang);
            param[4] = new SqlParameter("@SDTGiaoHang", hoaDonDTO.SDTGiaoHang);
            param[5] = new SqlParameter("@TongTien", hoaDonDTO.TongTien);
            param[6] = new SqlParameter("@TrangThai", hoaDonDTO.TrangThai);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Update(HoaDonDTO hoaDonDTO)
        {
            String query = "UPDATE HoaDon SET TenTaiKhoan = @TenTaiKhoan, NgayMua = @NgayMua, DiaChiGiaoHang = @DiaChiGiaoHang, SDTGiaoHang = @SDTGiaoHang, TongTien = @TongTien, TrangThai = @TrangThai WHERE MaHD = @MaHD)";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@MaHD", hoaDonDTO.MaHD);
            param[1] = new SqlParameter("@TenTaiKhoan", hoaDonDTO.TenTaiKhoan);
            param[2] = new SqlParameter("@NgayMua", hoaDonDTO.NgayMua.ToString("MM-dd-yyyy"));
            param[3] = new SqlParameter("@DiaChiGiaoHang", hoaDonDTO.DiaChiGiaoHang);
            param[4] = new SqlParameter("@SDTGiaoHang", hoaDonDTO.SDTGiaoHang);
            param[5] = new SqlParameter("@TongTien", hoaDonDTO.TongTien);
            param[6] = new SqlParameter("@TrangThai", hoaDonDTO.TrangThai);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        public static Boolean Delete(String maHD)
        {
            String query = "UPDATE HoaDon SET TrangThai = 0 WHERE MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaHD", maHD);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        private static HoaDonDTO ConvertToDTO(DataRow dr)
        {
            HoaDonDTO result = new HoaDonDTO();
            result.MaHD = Convert.ToString(dr["MaHD"]);
            result.TenTaiKhoan = Convert.ToString(dr["TenTaiKhoan"]);
            result.NgayMua = Convert.ToDateTime(dr["NgayMua"]);
            result.DiaChiGiaoHang = Convert.ToString(dr["DiaChiGiaoHang"]);
            result.SDTGiaoHang = Convert.ToString(dr["SDTGiaoHang"]);
            result.TongTien = Convert.ToInt32(dr["TongTien"]);
            result.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return result;
        }
    }
}
