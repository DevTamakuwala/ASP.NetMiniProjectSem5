<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Registration.aspx.vb" Inherits="Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>D&D Clothing</title>
    <link href="Registration.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="box">
    <div class="content">
        <div class="text">Registration</div>
            <form runat="server">
                <div class="field">
                    <asp:TextBox type="text" placeholder="Email Id" runat="server" ID="txtEmail"></asp:TextBox>
                </div>
                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtEmail" ForeColor="Red">Please Enter Email</asp:RequiredFieldValidator>
                    <br /><asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                        runat="server" ErrorMessage="RegularExpressionValidator" ForeColor="Red" 
                        ControlToValidate="txtEmail" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Visible="False">Please Enter Valid Email</asp:RegularExpressionValidator>
                </div>
                <div class="field">
                    <asp:TextBox type="text" placeholder="Name" runat="server" ID="txtName"></asp:TextBox>
                </div>
                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ForeColor="Red" ErrorMessage="RequiredFieldValidator" 
                        ControlToValidate="txtName">Please Enter Name</asp:RequiredFieldValidator>
                </div>
                <div class="field">
                    <asp:TextBox type="text" placeholder="User name" runat="server" ID="txtUName"></asp:TextBox>
                </div>

                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUName">Please Enter Username</asp:RequiredFieldValidator>
                </div>

                <asp:Label ID="lblErrorMsg" runat="server" ForeColor="Red"></asp:Label>
                <div class="field">
                    <asp:TextBox type="password" placeholder="Password" runat="server" ID="txtPass"></asp:TextBox>
                </div>
                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ForeColor="Red" ErrorMessage="RequiredFieldValidator" 
                        ControlToValidate="txtPass">Please Enter Password</asp:RequiredFieldValidator>
                </div>
                <div class="field">
                    <asp:TextBox type="password" placeholder="Confirm Password" runat="server" ID="txtCPass"></asp:TextBox>
                </div>
                <div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="RequiredFieldValidator" ForeColor="Red" 
                        ControlToValidate="txtCPass">Please Re-enter Password</asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ErrorMessage="CompareValidator" ForeColor="Red" ControlToCompare="txtPass" 
                        ControlToValidate="txtCPass" Visible="False">Password are not same. Please Check</asp:CompareValidator>
                </div>
                <div class="Gender">
                    Gender: <asp:RadioButton ID="rbtnMale" CssClass="gender" runat="server" Text=" Male" GroupName="gender" />
                    <asp:RadioButton ID="rbtnFemale" CssClass="gender" runat="server" Text=" Female" GroupName="gender" />
                </div>
                <asp:Button ID="btnReg" CssClass="btnReg" runat="server" Text="Register"/>
                <div class="Login">Already User..!!&nbsp    <a href="Login.aspx">Login here</a></div>
            </form> 
        </div>
    </div>
</body>
</html>
