<%@ Page Title="" Language="C#" MasterPageFile="~/HomeLayout.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="GUI.DangNhap" %>

<asp:Content ID="conTitle" ContentPlaceHolderID="cphTitle" runat="server">
    Đăng nhập
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
                            <h5 class="auth-title">Đăng nhập</h5>

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

                                 <div class="form-group mb-0 text-center">
                                    <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" CssClass="btn btn-danger btn-block" OnClick="btnDangNhap_Click" />
                                </div>

                            </div>

                        </div>
                        <!-- end card-body -->
                    </div>
                    <!-- end card -->

                    <div class="row mt-3">
                        <div class="col-12 text-center">
                            <p><a href="#" class="text-muted ml-1 font-weight-semibold">Quên mật khẩu?</a></p>
                            <p class="text-muted">Chưa có tài khoản? <a href="DangKy.aspx" class="text-muted ml-1"><b class="font-weight-semibold">Đăng ký</b></a></p>
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
</asp:Content>
<asp:Content ID="conJs" ContentPlaceHolderID="cphJs" runat="server">
</asp:Content>
