using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        public static List<HoaDonDTO> Get()
        {
            return HoaDonDAO.Get();
        }
        public static List<HoaDonDTO> Get(Boolean trangThai)
        {
            return HoaDonDAO.Get(trangThai);
        }
        public static HoaDonDTO GetObjectByPrimaryKey(String maHD)
        {
            return HoaDonDAO.GetObjectByPrimaryKey(maHD);
        }
        public static Boolean Insert(HoaDonDTO hoaDonDTO)
        {
            if(!HoaDonDAO.IsExist(hoaDonDTO.MaHD))
            {
                return HoaDonDAO.Insert(hoaDonDTO);
            }
            return false;
        }
        public static Boolean Update(HoaDonDTO hoaDonDTO)
        {
            if (HoaDonDAO.IsExist(hoaDonDTO.MaHD))
            {
                return HoaDonDAO.Update(hoaDonDTO);
            }
            return false;
        }
        public static Boolean Delete(String maHD)
        {
            if (HoaDonDAO.IsExist(maHD))
            {
                return HoaDonDAO.Delete(maHD);
            }
            return false;
        }
    }
}
