<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EditItems.aspx.vb" Inherits="EditItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container my-4">
    <div class="row">
        <asp:Repeater ID="rptrBook" runat="server">
            <ItemTemplate>
                <div class="card m-4" style="width: 18rem;">
                    <h2><%# Eval("pname")%></h2>
                    <img class="card-img-top" src="images/<%#Eval("image") %>" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title">by,<%# Eval("company")%></h5>
                        <p class="card-text"><%# Eval("description")%></p>
                        <p class="card-text">Rs. <%# Eval("price")%></p>
                        <a class="btn btn-primary" href="EditItems.aspx?uid=<%# Eval("pid")%>">Update</a>
                        <a class="btn btn-primary" href="EditItems.aspx?did=<%# Eval("pid")%>">Delete</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div>
    <table class="table table-striped">
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <tr>
                        <th>Product Name</th>
                        <th>Comapny</th>
                        <th>Description</th>
                        <th>Price</th>
                        <th>Image</th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("pname")%></td>
                        <td><%# Eval("company")%></td>
                        <td><%# Eval("description")%></td>
                        <td><%# Eval("price")%></td>
                        <td><img height="150px" src="images/<%#Eval("image") %>" alt="Card image cap"></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
    </table>
    </div>
</div>
<div class="row">
    <div class="col-md-3"></div>
    <div class="col-md-6 border border-primary p-4 my-5">
        <table class="table table-hover">
            <tr>
                <td>Product ID</td>
                <td>
                    <asp:TextBox ID="txtPid" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Product Name</td>
                <td>
                    <asp:TextBox ID="txtPname" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Comapny Name</td>
                <td>
                    <asp:TextBox ID="txtCname" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Price</td>
                <td>
                    <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter Descriptin</td>
                <td>
                    <asp:TextBox ID="txtDesc" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Select Image</td>
                <td>
                    <asp:FileUpload ID="fup" CssClass="form-control" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button CssClass="btn btn-warning" ID="btnUpdate" runat="server" Text="Update" />
                </td>
            </tr>
        </table>
    </div>
    <div class="col-md-3"></div>
</div>

</asp:Content>

