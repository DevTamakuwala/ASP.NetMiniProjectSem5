<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AddNewItem.aspx.vb" Inherits="AddNewItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container my-4">

    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-6 border border-primary p-4 my-5">
            <table class="table table-hover">
                <tr>
                    <td>Product Name</td>
                    <td>
                        <asp:TextBox ID="txtBname" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Comapny Name</td>
                    <td>
                        <asp:TextBox ID="txtAname" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Descriptin</td>
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
                        <asp:Button CssClass="btn btn-success" ID="btnInsert" runat="server" Text="Insert" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="col-md-3"></div>
    </div>
</div>
</asp:Content>

