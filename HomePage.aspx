<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="HomePage.aspx.vb" Inherits="HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container my-4">
    <div class="row">
        <div class="row col-md-10">
            <div class="row mx-2 my-2">
                <asp:Repeater ID="rptrBook" runat="server">
                    <ItemTemplate>
                        <div class="card m-2" style="width: 18rem;">
                            <h2><%# Eval("pname")%></h2>
                            <img class="card-img-top" src="images/<%#Eval("image") %>" alt="Card image cap">
                            <div class="card-body">
                                <h5 class="card-title">by,<%# Eval("company")%></h5>
                                <p class="card-text"><%# Eval("description")%></p>
                                <p class="card-text">Rs. <%# Eval("price")%></p>
                                <% If Session("name") <> "Admin" Then%>
                                    <a class="btn btn-primary" href="MoreInfo.aspx?pid=<%#Eval("pid") %>">More Info</a>
                                <% End If%>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            
            </div>
        </div>
        <div class="col-md-2 text-success">
            Search By Price:<br />
            Min Price
            <asp:TextBox ID="txtMinPrice" class="my-2" runat="server" Height="25px" Width="60px"></asp:TextBox><br />
            Max Price
            <asp:TextBox ID="txtMaxPrice" class="my-2" runat="server" Height="25px" Width="60px"></asp:TextBox><br />   
            <asp:Button ID="btnSeacrhPrice" class="my-2 btn btn-success" runat="server" Text="search by price" />
            <asp:Button ID="btnSort" runat="server" class="btn btn-success" Text="Sort By Price" />
            <asp:Button ID="btnSortDesc" runat="server"  class="my-2 btn btn-success" Text="Sort By Price Desc" />
            <asp:Button ID="btnSortName" runat="server" class="btn btn-success" Text="Sort By Name" /><br />
            Enter Name to be searched
            <asp:TextBox ID="txtSearchName" class="my-2" runat="server"></asp:TextBox>
            <asp:Button ID="btnNameSearch" runat="server" class="my-2 btn btn-success" Text="search by name" />
            <asp:Button ID="btnReset" runat="server" class="my-2 btn btn-success" Text="Reset" />
        </div>
    </div>
</div>
</asp:Content>