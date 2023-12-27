<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>D&D Clothing</title>
    <link href="Login.css" rel="Stylesheet" />
</head>
<body>
    <div class="box">
        <div class="content">    
            <form runat="server">
                <div class="text">Login</div>
                <div class="field">
                    <asp:TextBox CssClass="input" runat="server" ID="txtUser" placeholder="User Name"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUser" 
                        ForeColor="Red">Please Enter Username</asp:RequiredFieldValidator>
                <div class="field">
                    <asp:TextBox type="password" CssClass="input2" runat="server" ID="txtPass" placeholder="Password"></asp:TextBox>
                </div>
                <div class="error">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="RequiredFieldValidator" ControlToValidate="txtPass" 
                        ForeColor="Red">Please Enter Password   </asp:RequiredFieldValidator>
                    <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red"></asp:Label>                
                </div>
                <div>
                    <asp:Button ID="btnLogin" CssClass="button" runat="server" Text="Login"/>
                </div>
                <div class="Login">Create New Account. &nbsp <a href="Registration.aspx">Register here</a></div>
            </form>
        </div>
    </div>
</body>
</html>