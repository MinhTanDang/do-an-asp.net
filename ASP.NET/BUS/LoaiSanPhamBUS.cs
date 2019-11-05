using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
    public class LoaiSanPhamBUS
    {
        public static List<LoaiSanPhamDTO> Get()
        {
            return LoaiSanPhamDAO.Get();
        }
        public static List<LoaiSanPhamDTO> Get(Boolean trangThai)
        {
            return LoaiSanPhamDAO.Get(trangThai);
        }
        public static LoaiSanPhamDTO GetObjectByPrimaryKey(String maLoaiSP)
        {
            return LoaiSanPhamDAO.GetObjectByPrimaryKey(maLoaiSP);
        }
        public static Boolean Insert(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            if (!LoaiSanPhamDAO.IsExist(loaiSanPhamDTO.MaLoaiSP))
            {
                return LoaiSanPhamDAO.Update(loaiSanPhamDTO);
            }
            return false;
        }
        public static Boolean Update(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            if (LoaiSanPhamDAO.IsExist(loaiSanPhamDTO.MaLoaiSP))
            {
                return LoaiSanPhamDAO.Update(loaiSanPhamDTO);
            }
            return false;
        }
        public static Boolean Delete(String maLoaiSP)
        {
            if (LoaiSanPhamDAO.IsExist(maLoaiSP))
            {
                return LoaiSanPhamDAO.Delete(maLoaiSP);
            }
            return false;
        }
    }
}
