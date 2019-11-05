using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CTHoaDonBUS
    {
        public static List<CTHoaDonDTO> Get()
        {
            return CTHoaDonDAO.Get();
        }
        public static CTHoaDonDTO GetObjectByPrimaryKey(String maHD, String maSP)
        {
            return CTHoaDonDAO.GetObjectByPrimaryKey(maHD, maSP);
        }
        public static Boolean Insert(CTHoaDonDTO ctHoaDonDTO)
        {
            if(!CTHoaDonDAO.IsExist(ctHoaDonDTO.MaHD, ctHoaDonDTO.MaSP))
            {
                return CTHoaDonDAO.Insert(ctHoaDonDTO);
            }
            return false;
        }
        public static Boolean Update(CTHoaDonDTO ctHoaDonDTO)
        {
            if (CTHoaDonDAO.IsExist(ctHoaDonDTO.MaHD, ctHoaDonDTO.MaSP))
            {
                return CTHoaDonDAO.Update(ctHoaDonDTO);
            }
            return false;
        }
        public static Boolean Delete(String maHD, String maSP)
        {
            if (CTHoaDonDAO.IsExist(maHD, maSP))
            {
                return CTHoaDonDAO.Delete(maHD, maSP);
            }
            return false;
        }
    }
}
