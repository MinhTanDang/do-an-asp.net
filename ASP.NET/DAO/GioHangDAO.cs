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
    public class GioHangDAO
    {
        public static Boolean IsExist(String tenTaiKhoan, String maSP)
        {
            String query = "SELECT COUNT(*) FROM GioHang WHERE TenTaiKhoan = @TenTaiKhoan AND MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
            param[1] = new SqlParameter("@MaSP", maSP);
            return (Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) >= 1);
        }
        public static List<GioHangDTO> Get()
        {
            List<GioHangDTO> result = new List<GioHangDTO>();
            String query = "SELECT * FROM GioHang";
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static GioHangDTO GetObjectByPrimaryKey(String tenTaiKhoan, String maSP)
        {
            if (IsExist(tenTaiKhoan, maSP))
            {
                String query = "SELECT * FROM GioHang WHERE TenTaiKhoan = @TenTaiKhoan AND MaSP = @MaSP";
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
                param[1] = new SqlParameter("@MaSP", maSP);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
            }
            return null;
        }
        public static Boolean Insert(GioHangDTO gioHangDTO)
        {
            String query = "INSERT INTO GioHang (TenTaiKhoan, MaSP, SoLuong) VALUES (@TenTaiKhoan, @MaSP, @SoLuong)";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TenTaiKhoan", gioHangDTO.TenTaiKhoan);
            param[1] = new SqlParameter("@MaSP", gioHangDTO.MaSP);
            param[2] = new SqlParameter("@SoLuong", gioHangDTO.SoLuong);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Update(GioHangDTO gioHangDTO)
        {
            String query = "UPDATE GioHang SET MaSP = @MaSP, SoLuong = @SoLuong WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TenTaiKhoan", gioHangDTO.TenTaiKhoan);
            param[1] = new SqlParameter("@MaSP", gioHangDTO.MaSP);
            param[2] = new SqlParameter("@SoLuong", gioHangDTO.SoLuong);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        public static Boolean Delete(String tenTaiKhoan, String maSP)
        {
            String query = "DELETE FROM GioHang WHERE TenTaiKhoan = @TenTaiKhoan AND MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
            param[1] = new SqlParameter("@MaSP", maSP);
            return (DataProvider.ExecuteDeleteQuery(query, param) == 1);
        }
        private static GioHangDTO ConvertToDTO(DataRow dr)
        {
            GioHangDTO result = new GioHangDTO();
            result.TenTaiKhoan = Convert.ToString(dr["TenTaiKhoan"]);
            result.MaSP = Convert.ToString(dr["MaSP"]);
            result.SoLuong = Convert.ToInt32(dr["SoLuong"]);
            return result;
        }
    }
}
