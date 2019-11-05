using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> Get()
        {
            return SanPhamDAO.Get();
        }
        public static List<SanPhamDTO> Get(Boolean trangThai)
        {
            return SanPhamDAO.Get(trangThai);
        }
        public static DataTable GetDataTable()
        {
            return SanPhamDAO.GetDataTable();
        }
        public static SanPhamDTO GetObjectByPrimaryKey(String maSP)
        {
            return SanPhamDAO.GetObjectByPrimaryKey(maSP);
        }
        public static Boolean Insert(SanPhamDTO sanPhamDTO)
        {
           if(!SanPhamDAO.IsExist(sanPhamDTO.TenSP))
           {
               return SanPhamDAO.Insert(sanPhamDTO);
           }
           return false;
        }
        public static Boolean Update(SanPhamDTO sanPhamDTO)
        {
            if (SanPhamDAO.IsExist(sanPhamDTO.TenSP))
            {
                return SanPhamDAO.Update(sanPhamDTO);
            }
            return false;
        }
        public static Boolean Delete(String maSP)
        {
            if (SanPhamDAO.IsExist(maSP))
            {
                return SanPhamDAO.Delete(maSP);
            }
            return false;
        }
    }
}
