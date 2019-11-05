using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace GUI
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                HienThiDanhSachSanPham(gvDanhSachSanPham);
                LayDanhSachLoaiSanPham(ddlLoaiSanPham);
            }
        }
        public void HienThiDanhSachSanPham(GridView gv)
        {
            gv.DataSource = SanPhamBUS.GetDataTable();
            gv.DataBind();
        }

        public void LayDanhSachLoaiSanPham(DropDownList ddl)
        {
            ddl.DataSource = LoaiSanPhamBUS.Get();
            ddl.DataTextField = "TenLoaiSP";
            ddl.DataValueField = "MaLoaiSP";
            ddl.DataBind();
        }

        protected void gvDanhSachSanPham_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.Equals("Chon"))
            {
                txtMaSP.Enabled = false;
                String maSP = Convert.ToString(e.CommandArgument);
                SanPhamDTO sanPhamDTO = SanPhamBUS.GetObjectByPrimaryKey(maSP);
                if(!sanPhamDTO.Equals(null))
                {
                    txtMaSP.Text = sanPhamDTO.MaSP;
                    txtTenSP.Text = sanPhamDTO.TenSP;
                    txtMau.Text = sanPhamDTO.Mau;
                    txtKichThuoc.Text = Convert.ToString(sanPhamDTO.KichThuoc);
                    txtMoTa.Text = sanPhamDTO.MoTa;
                    txtGiaTien.Text = Convert.ToString(sanPhamDTO.GiaTien);
                    txtSoLuongTonKho.Text = Convert.ToString(sanPhamDTO.SoLuongTonKho);
                }
                XoaForm();
            }
            else
            {
                XoaForm();
            }
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            String maSP, tenSP, mau, moTa, maLoaiSP;
            Int32 kichThuoc, giaTien, soLuongTonKho;
            Boolean trangThai;
            SanPhamDTO sanPhamDTO;
            //
            maSP = txtMaSP.Text;
            tenSP = txtTenSP.Text;
            mau = txtMau.Text;
            kichThuoc = Convert.ToInt32(txtKichThuoc.Text);
            moTa = txtMoTa.Text;
            giaTien = Convert.ToInt32(txtGiaTien.Text);
            soLuongTonKho = Convert.ToInt32(txtSoLuongTonKho.Text);
            maLoaiSP = ddlLoaiSanPham.SelectedValue;
            trangThai = Convert.ToBoolean(ddlTrangThai.SelectedValue);
            sanPhamDTO = new SanPhamDTO(maSP, tenSP, mau, kichThuoc, moTa, giaTien, soLuongTonKho, maLoaiSP, trangThai);
            //
            if(SanPhamBUS.Insert(sanPhamDTO))
            {
                
            }
            else
            {

            }
            txtMaSP.Enabled = true;
        }

        protected void ddlLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("<script>alert(\"s\")</script>");
        }
        public void XoaForm()
        {
            foreach (Control control in Form.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = String.Empty;
                }
            }
        }
    }
}