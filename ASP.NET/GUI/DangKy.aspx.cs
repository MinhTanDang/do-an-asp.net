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
    public partial class DangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {}
        //
        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            String hoTen = txtHoTen.Text;
            String email = txtEmail.Text;
            String sdt = txtSDT.Text;
            String diaChi = txtDiaChi.Text;
            TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO(tenTaiKhoan, matKhau, hoTen, email, sdt, diaChi);
            //
            if(TaiKhoanBUS.Register(taiKhoanDTO))
            {
                lblMsg.Text = "Đăng ký tài khoản thành công!";
            }
            else
            {
                lblMsg.Text = "Đăng ký tài khoản thất bại!";
            }
            XoaForm();
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