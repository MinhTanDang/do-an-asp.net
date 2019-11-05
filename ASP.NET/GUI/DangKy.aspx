<%@ Page Title="" Language="C#" MasterPageFile="~/HomeLayout.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="GUI.DangKy" %>

<asp:Content ID="conTitle" ContentPlaceHolderID="cphTitle" runat="server">
    Đăng ký tài khoản
</asp:Content>
<asp:Content ID="conCss" ContentPlaceHolderID="cphCss" runat="server">
</asp:Content>
<asp:Content ID="conMainContent" ContentPlaceHolderID="cphMainContent" runat="server">
    <div class="account-pages mt-5 mb-5">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-md-8 col-lg-6 col-xl-5">
                    <div class="card">

                        <div class="card-body p-4">
                            <h5 class="auth-title">Đăng ký tài khoản</h5>

                            <div>
                                <div>
                                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Font-Size="Large"></asp:Label>
                                </div>

                                <div class="form-group">
                                    <label for="ten-tai-khoan">Tên tài khoản</label>
                                    <asp:TextBox ID="txtTenTaiKhoan" runat="server" CssClass="form-control" placeholder="Nhập tên tài khoản" required="Tên tài khoản không được để trống"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="mat-khau">Mật khẩu</label>
                                    <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" placeholder="Nhập mật khẩu" required="Mật khẩu không được để trống" TextMode="Password"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="ho-ten">Họ tên</label>
                                    <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" placeholder="Nhập họ tên" required="Họ tên không được để trống"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="email">Email</label>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Nhập email" required="Email không được để trống" TextMode="Email"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="sdt">Số điện thoại</label>
                                    <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control" placeholder="Nhập số điện thoại" required="Số điện thoại không được để trống" TextMode="Phone"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <label for="dia-chi">Địa chỉ</label>
                                    <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" placeholder="Nhập địa chỉ" required="Địa chỉ không được để trống"></asp:TextBox>
                                </div>

                                <div class="form-group mb-0 text-center">
                                    <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" CssClass="btn btn-danger btn-block" OnClick="btnDangKy_Click" />
                                </div>

                            </div>

                        </div>
                        <!-- end card-body -->
                    </div>
                    <!-- end card -->

                    <div class="row mt-3">
                        <div class="col-12 text-center">
                            <p class="text-muted">Đã có tài khoản?  <a href="DangNhap.aspx" class="text-muted ml-1"><b class="font-weight-semibold">Đăng nhập</b></a></p>
                        </div>
                        <!-- end col -->
                    </div>
                    <!-- end row -->

                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end page -->
</asp:Content>
<asp:Content ID="conJs" ContentPlaceHolderID="cphJs" runat="server">
</asp:Content>
