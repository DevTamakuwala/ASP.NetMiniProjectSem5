<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="MyOrdesrs.aspx.vb" Inherits="MyOrdesrs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container">
    <table class="table table-striped my-5">
        <thead>
            <tr>
                <th>OrderID</th>
                <th>Productr Name</th>
                <% If Session("name") = "Admin" Then%>
                    <th>Username</th>
                <% End If%>
                <th>Price</th>
                <th>Date</th>
                <th>Image</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="myorders" runat="server">
            <ItemTemplate>
                    <tr>
                    <th><%#Eval("orderid") %></th>
                    <th><%# Eval("pname")%></th>
                    <% If Session("name") = "Admin" Then%>
                        <th><%# Eval("Name")%></th>
                    <% End If%>
                    <th><%# Eval("price")%></th>
                    <th><%# Eval("orderDataTime")%></th>
                    <th><img src="images/<%# Eval("image")%>" alt="image" height="100px"/></th>
                </tr>
            </ItemTemplate>
            </asp:Repeater> 
        </tbody>
    </table>
</div>
</asp:Content>

