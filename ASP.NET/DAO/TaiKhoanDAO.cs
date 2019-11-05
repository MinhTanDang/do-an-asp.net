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
    public class TaiKhoanDAO
    {
        public static Boolean Register(TaiKhoanDTO taiKhoanDTO)
        {
            if(!TaiKhoanDAO.IsExist(taiKhoanDTO.TenTaiKhoan))
            {
                return TaiKhoanDAO.Insert(taiKhoanDTO);
            }
            return false;
        }
        public static Boolean Login(String tenTaiKhoan, String matKhau)
        {
            if(TaiKhoanDAO.IsExist(tenTaiKhoan))
            {
                String password = GetPassword(tenTaiKhoan);
                return matKhau.Equals(password);
            }
            return false;
        }
        public static String GetPassword(String tenTaiKhoan)
        {
            String query = "SELECT MatKhau FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
            return Convert.ToString(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]);
        }
        public static Boolean IsExist(String tenTaiKhoan)
        {
            String query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
            return (Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) >= 1);
        }
        public static List<TaiKhoanDTO> Get()
        {
            List<TaiKhoanDTO> result = new List<TaiKhoanDTO>();
            String query = "SELECT * FROM TaiKhoan";
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static List<TaiKhoanDTO> Get(Boolean trangThai)
        {
            List<TaiKhoanDTO> result = new List<TaiKhoanDTO>();
            String query = "SELECT * FROM TaiKhoan WHERE TrangThai = @TrangThai";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TrangThai", trangThai);
            DataTable dtbTemp = DataProvider.ExecuteSelectQuery(query, param);
            foreach (DataRow dr in dtbTemp.Rows)
            {
                result.Add(ConvertToDTO(dr));
            }
            return result;
        }
        public static TaiKhoanDTO GetObjectByPrimaryKey(String tenTaiKhoan)
        {
            if(IsExist(tenTaiKhoan))
            {
                String query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
                return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
            }
            return null;
        }
        public static Boolean Insert(TaiKhoanDTO taiKhoanDTO)
        {
            String query = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, HoTen, Email, SDT, DiaChi, AnhDaiDien, LaAdmin, TrangThai) VALUES (@TenTaiKhoan, @MatKhau, @HoTen, @Email, @SDT, @DiaChi, @AnhDaiDien, @LaAdmin, @TrangThai)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@TenTaiKhoan", taiKhoanDTO.TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", taiKhoanDTO.MatKhau);
            param[2] = new SqlParameter("@HoTen", taiKhoanDTO.HoTen);
            param[3] = new SqlParameter("@Email", taiKhoanDTO.Email);
            param[4] = new SqlParameter("@SDT", taiKhoanDTO.SDT);
            param[5] = new SqlParameter("@DiaChi", taiKhoanDTO.DiaChi);
            param[6] = new SqlParameter("@AnhDaiDien", taiKhoanDTO.AnhDaiDien);
            param[7] = new SqlParameter("@LaAdmin", taiKhoanDTO.LaAdmin);
            param[8] = new SqlParameter("@TrangThai", taiKhoanDTO.TrangThai);
            return (DataProvider.ExecuteInsertQuery(query, param) == 1);
        }
        public static Boolean Update(TaiKhoanDTO taiKhoanDTO)
        {
            String query = "UPDATE TaiKhoan SET MatKhau = @MatKhau, HoTen = @HoTen, Email = @Email, SDT = @SDT, DiaChi = @DiaChi, AnhDaiDien = @AnhDaiDien, LaAdmin = @LaAdmin, TrangThai = @TrangThai WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@TenTaiKhoan", taiKhoanDTO.TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", taiKhoanDTO.MatKhau);
            param[2] = new SqlParameter("@HoTen", taiKhoanDTO.HoTen);
            param[3] = new SqlParameter("@Email", taiKhoanDTO.Email);
            param[4] = new SqlParameter("@SDT", taiKhoanDTO.SDT);
            param[5] = new SqlParameter("@DiaChi", taiKhoanDTO.DiaChi);
            param[6] = new SqlParameter("@AnhDaiDien", taiKhoanDTO.AnhDaiDien);
            param[7] = new SqlParameter("@LaAdmin", taiKhoanDTO.LaAdmin);
            param[8] = new SqlParameter("@TrangThai", taiKhoanDTO.TrangThai);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        public static Boolean Delete(String tenTaiKhoan)
        {
            String query = "UPDATE TaiKhoan SET TrangThai = 0 WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTaiKhoan);
            return (DataProvider.ExecuteUpdateQuery(query, param) == 1);
        }
        private static TaiKhoanDTO ConvertToDTO(DataRow dr)
        {
            TaiKhoanDTO result = new TaiKhoanDTO();
            result.TenTaiKhoan = Convert.ToString(dr["TenTaiKhoan"]);
            result.MatKhau = Convert.ToString(dr["MatKhau"]);
            result.HoTen = Convert.ToString(dr["HoTen"]);
            result.Email = Convert.ToString(dr["Email"]);
            result.SDT = Convert.ToString(dr["SDT"]);
            result.DiaChi = Convert.ToString(dr["DiaChi"]);
            result.AnhDaiDien = Convert.ToString(dr["AnhDaiDien"]);
            result.LaAdmin = Convert.ToBoolean(dr["AnhDaiDien"]);
            result.TrangThai = Convert.ToBoolean(dr["AnhDaiDien"]);
            return result;
        }
    }
}
