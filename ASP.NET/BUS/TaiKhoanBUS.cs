using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static Boolean Register(TaiKhoanDTO taiKhoanDTO)
        {
            taiKhoanDTO.MatKhau = MD5Encode(taiKhoanDTO.MatKhau);
            return TaiKhoanDAO.Register(taiKhoanDTO);
        }
        public static Boolean Login(String tenTaiKhoan, String matKhau)
        {
            matKhau = MD5Encode(matKhau);
            return TaiKhoanDAO.Login(tenTaiKhoan, matKhau);
        }
        public static String GetPassword(String tenTaiKhoan)
        {
            return TaiKhoanDAO.GetPassword(tenTaiKhoan);
        }
        public static List<TaiKhoanDTO> Get()
        {
            return TaiKhoanDAO.Get();
        }
        public static List<TaiKhoanDTO> Get(Boolean trangThai)
        {
            return TaiKhoanDAO.Get(trangThai);
        }
        public static TaiKhoanDTO GetObjectByPrimaryKey(String tenTaiKhoan)
        {
            return TaiKhoanDAO.GetObjectByPrimaryKey(tenTaiKhoan);
        }
        public static Boolean Insert(TaiKhoanDTO taiKhoanDTO)
        {
            if(!TaiKhoanDAO.IsExist(taiKhoanDTO.TenTaiKhoan))
            {
                return TaiKhoanDAO.Insert(taiKhoanDTO);
            }
            return false;
        }
        public static Boolean Update(TaiKhoanDTO taiKhoanDTO)
        {
            if (TaiKhoanDAO.IsExist(taiKhoanDTO.TenTaiKhoan))
            {
                return TaiKhoanDAO.Update(taiKhoanDTO);
            }
            return false;
        }
        public static Boolean Delete(String tenTaiKhoan)
        {
            if (TaiKhoanDAO.IsExist(tenTaiKhoan))
            {
                return TaiKhoanDAO.Delete(tenTaiKhoan);
            }
            return false;
        }
        private static String MD5Encode(String input)
        {
            MD5 md5 = MD5.Create();
            Byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                result.Append(data[i].ToString("x2"));
            }
            return result.ToString();
        }
    }
}
