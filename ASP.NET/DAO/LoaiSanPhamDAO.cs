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
    public class LoaiSanPhamDAO
    {
        public static Boolean IsExist(String maLoaiSP)
        {
            String query = "SELECT COUNT(*) FROM LoaiSanPham WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return (Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) >= 1);
        }
        public static List<LoaiSanPhamDTO> Get()
        {
            List<LoaiSanPhamDTO> result = new List<LoaiSanPhamDTO>();
            String query = "SELECT * FROM LoaiSanPham";
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static List<LoaiSanPhamDTO> Get(Boolean trangThai)
        {
            List<LoaiSanPhamDTO> result = new List<LoaiSanPhamDTO>();
            String query = "SELECT * FROM LoaiSanPham WHERE TrangThai = @TrangThai";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TrangThai", trangThai);
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query, param);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static LoaiSanPhamDTO GetObjectByPrimaryKey(String maLoaiSP)
        {
            if (IsExist(maLoaiSP))
            {
                String query = "SELECT * FROM LoaiSanPham WHERE MaLoaiSP = @MaLoaiSP";
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
            }
            return null;
        }
        public static Boolean Insert(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            String query = "INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES (@MaLoaiSP, @TenLoaiSP, @TrangThai)";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@MaLoaiSP", loaiSanPhamDTO.MaLoaiSP);
            param[1] = new SqlParameter("@TenLoaiSP", loaiSanPhamDTO.TenLoaiSP);
            param[2] = new SqlParameter("@TrangThai", loaiSanPhamDTO.TrangThai);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Update(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            String query = "UPDATE LoaiSanPham SET TenLoaiSP = @TenLoaiSP, TrangThai = @TrangThai WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@MaLoaiSP", loaiSanPhamDTO.MaLoaiSP);
            param[1] = new SqlParameter("@TenLoaiSP", loaiSanPhamDTO.TenLoaiSP);
            param[2] = new SqlParameter("@TrangThai", loaiSanPhamDTO.TrangThai);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        public static Boolean Delete(String maLoaiSP)
        {
            String query = "UPDATE LoaiSanPham SET TrangThai = 0 WHERE MaLoaiSP = @MaLoaiSP";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiSP", maLoaiSP);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        private static LoaiSanPhamDTO ConvertToDTO(DataRow dr)
        {
            LoaiSanPhamDTO result = new LoaiSanPhamDTO();
            result.MaLoaiSP = Convert.ToString(dr["MaLoaiSP"]);
            result.TenLoaiSP = Convert.ToString(dr["TenLoaiSP"]);
            result.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return result;
        }
    }
}
