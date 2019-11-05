<%@ Page Title="" Language="C#" MasterPageFile="~/HomeLayout.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="GUI.SanPham" %>

<asp:Content ID="conTitle" ContentPlaceHolderID="cphTitle" runat="server">
    Quản lý sản phẩm
</asp:Content>
<asp:Content ID="conCss" ContentPlaceHolderID="cphCss" runat="server">
</asp:Content>
<asp:Content ID="conMainContent" ContentPlaceHolderID="cphMainContent" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="card">
                <div class="card-body">
                    <div>

                        <div>
                            <asp:Label ID="lblMsg" runat="server" Font-Size="Large"></asp:Label>
                        </div>

                        <div class="form-group">
                            <label>Mã sản phẩm</label>
                            <asp:TextBox ID="txtMaSP" runat="server" CssClass="form-control" placeholder="Nhập mã sản phẩm"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Tên sản phẩm</label>
                            <asp:TextBox ID="txtTenSP" runat="server" CssClass="form-control" placeholder="Nhập tên sản phẩm"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Màu</label>
                            <asp:TextBox ID="txtMau" runat="server" CssClass="form-control" placeholder="Nhập màu"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label">Kích thước</label>
                            <asp:TextBox ID="txtKichThuoc" runat="server" CssClass="form-control" placeholder="Nhập kích thước"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label">Mô tả</label>
                            <asp:TextBox ID="txtMoTa" runat="server" CssClass="form-control" placeholder="Nhập mô tả" TextMode="MultiLine"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Giá tiền</label>
                            <asp:TextBox ID="txtGiaTien" runat="server" CssClass="form-control mdi-comment-text-multiple" placeholder="Nhập giá tiền"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Số lượng</label>
                            <asp:TextBox ID="txtSoLuongTonKho" runat="server" CssClass="form-control" placeholder="Nhập số lượng"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label>Loại sản phẩm</label>
                            <table>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlLoaiSanPham" runat="server" OnSelectedIndexChanged="ddlLoaiSanPham_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div class="form-group">
                            <label for="trang-thai">Trạng thái</label>
                            <table>
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="ddlTrangThai" runat="server">
                                            <asp:ListItem Text="Kinh doanh" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="Ngừng kinh doanh" Value="0"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div class="form-group mb-0">
                            <asp:Button ID="btnLuu" runat="server" Text="Lưu" CssClass="btn btn-primary waves-effect waves-light" OnClick="btnLuu_Click"/>
                        </div>

                    </div>
                    <!-- end card-body-->
                </div>
                <!-- end card-->
            </div>
            <!-- end col -->
        </div>
    </div>
    <div class="row">
        <div class="col-12">
            <div class="card">
                <div class="card-body">
                    <h4 class="header-title">Danh sách sản phẩm</h4>

                    <asp:GridView ID="gvDanhSachSanPham" runat="server" AutoGenerateColumns="False" CssClass="table dt-responsive nowrap" OnRowCommand="gvDanhSachSanPham_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="MaSP" HeaderText="Mã sản phẩm" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="Mau" HeaderText="Màu" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="KichThuoc" HeaderText="Kích thước" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="GiaTien" HeaderText="Giá tiền" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="SoLuongTonKho" HeaderText="Số lượng" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:BoundField DataField="TenLoaiSP" HeaderText="Loại sản phẩm" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:CheckBoxField DataField="TrangThai" HeaderText="Trạng thái" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" />
                            <asp:TemplateField ShowHeader="False" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="Chon" CommandArgument='<%# Eval("MaSP") %>' Text="Chọn" CssClass="btn btn-success waves-effect waves-light" />
                                    <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="Xoa" CommandArgument='<%# Eval("MaSP") %>' Text="Xóa" CssClass="btn btn-danger waves-effect waves-light" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                </div>
                <!-- end card body-->
            </div>
            <!-- end card -->
        </div>
        <!-- end col-->
    </div>

</asp:Content>
<asp:Content ID="conJs" ContentPlaceHolderID="cphJs" runat="server">
</asp:Content>
