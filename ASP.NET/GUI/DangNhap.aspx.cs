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
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        //
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            //
            if (TaiKhoanBUS.Login(tenTaiKhoan, matKhau))
            {
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblMsg.Text = "Tài khoản hoặc mật khẩu không chính xác!";
            }
            XoaForm();
        }
        public void XoaForm()
        {
            //foreach (Control control in frmMainContent.Controls) - frmMainContent ko hiểu!
            foreach (Control control in Form.Controls) //Chạy lên ko có tác dụng!
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = String.Empty;
                }
            }
        }
    }
}