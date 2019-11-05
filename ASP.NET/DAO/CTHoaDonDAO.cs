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
    public class CTHoaDonDAO
    {
        public static Boolean IsExist(String maHD, String maSP)
        {
            String query = "SELECT COUNT(*) FROM CTHoaDon WHERE MaHD = @MaHD AND MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@MaHD", maHD);
            param[1] = new SqlParameter("@MaSP", maSP);
            return (Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) >= 1);
        }
        public static List<CTHoaDonDTO> Get()
        {
            List<CTHoaDonDTO> result = new List<CTHoaDonDTO>();
            String query = "SELECT * FROM CTHoaDon";
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static CTHoaDonDTO GetObjectByPrimaryKey(String maHD, String maSP)
        {
            if (IsExist(maHD, maSP))
            {
                String query = "SELECT * FROM CTHoaDon WHERE MaHD = @MaHD AND MaSP = @MaSP";
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@MaHD", maHD);
                param[1] = new SqlParameter("@MaSP", maSP);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
            }
            return null;
        }
        public static Boolean Insert(CTHoaDonDTO ctHoaDonDTO)
        {
            String query = "INSERT INTO CTHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@MaHD", ctHoaDonDTO.MaHD);
            param[1] = new SqlParameter("@MaSP", ctHoaDonDTO.MaSP);
            param[2] = new SqlParameter("@SoLuong", ctHoaDonDTO.SoLuong);
            param[3] = new SqlParameter("@DonGia", ctHoaDonDTO.DonGia);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Update(CTHoaDonDTO ctHoaDonDTO)
        {
            String query = "UPDATE CTHoaDon SET MaSP = @MaSP, SoLuong = @SoLuong, DonGia = @DonGia WHERE MaHD = @MaHD";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@MaHD", ctHoaDonDTO.MaHD);
            param[1] = new SqlParameter("@MaSP", ctHoaDonDTO.MaSP);
            param[2] = new SqlParameter("@SoLuong", ctHoaDonDTO.SoLuong);
            param[3] = new SqlParameter("@DonGia", ctHoaDonDTO.DonGia);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        public static Boolean Delete(String maHD, String maSP)
        {
            String query = "DELETE FROM CTHoaDon WHERE MaHD = @MaHD AND MaSP = @MaSP";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@MaHD", maHD);
            param[1] = new SqlParameter("@MaSP", maSP);
            return (DataProvider.ExecuteDeleteQuery(query, param) == 1);
        }
        private static CTHoaDonDTO ConvertToDTO(DataRow dr)
        {
            CTHoaDonDTO result = new CTHoaDonDTO();
            result.MaHD = Convert.ToString(dr["MaHD"]);
            result.MaSP = Convert.ToString(dr["MaSP"]);
            result.SoLuong = Convert.ToInt32(dr["SoLuong"]);
            result.DonGia = Convert.ToInt32(dr["DonGia"]);
            return result;
        }
    }
}
