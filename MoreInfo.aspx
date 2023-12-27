<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="MoreInfo.aspx.vb" Inherits="MoreInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container my-4">
    <div class="row my-4">
    <div class="col-md-6">
        <asp:Image ID="pimg" Width="80%" runat="server" />
    </div>
    <div class="col-md-6">
        <h2><asp:Label ID="lblpname" runat="server" Text="Book 1"></asp:Label></h2> 
        <p>
            By,<asp:Label ID="lblAname" runat="server" Text="Dev"></asp:Label>
        </p>
        <div>
            Price 
            <asp:Label ID="lblPrice" runat="server" Text="12900"></asp:Label>
        </div>

        <div class="my-5 text-secondary">
            <asp:Label ID="lblDesc" runat="server" Text="akjdgakjsgdkjagdkjasgdkjgaskj"></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnByNow" runat="server" CssClass="btn btn-primary btn-lg" Text="Buy Now" />
        </div>
    </div>
</div>
</div>
</asp:Content>

