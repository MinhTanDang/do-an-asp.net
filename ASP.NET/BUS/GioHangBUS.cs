using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class GioHangBUS
    {
        public static List<GioHangDTO> Get()
        {
            return GioHangDAO.Get();
        }
        public static GioHangDTO GetObjectByPrimaryKey(String tenTaiKhoan, String maSP)
        {
            return GioHangDAO.GetObjectByPrimaryKey(tenTaiKhoan, maSP);
        }
        public static Boolean Insert(GioHangDTO gioHangDTO)
        {
            if(!GioHangDAO.IsExist(gioHangDTO.TenTaiKhoan, gioHangDTO.MaSP))
            {
                return GioHangDAO.Insert(gioHangDTO);
            }
            return false;
        }
        public static Boolean Update(GioHangDTO gioHangDTO)
        {
            if (GioHangDAO.IsExist(gioHangDTO.TenTaiKhoan, gioHangDTO.MaSP))
            {
                return GioHangDAO.Update(gioHangDTO);
            }
            return false;
        }
        public static Boolean Delete(String tenTaiKhoan, String maSP)
        {
            if (GioHangDAO.IsExist(tenTaiKhoan, maSP))
            {
                return GioHangDAO.Delete(tenTaiKhoan, maSP);
            }
            return false;
        }
    }
}
