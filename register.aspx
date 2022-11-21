<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="LoginPage__WEB.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/style.css" rel="stylesheet" />
</head>
<body>
    <div class="container" id="registerBox">
        <img src="images/user.png" class="user" />
        <h2>Register</h2>
        <form id="frmRegister" runat="server">
            <asp:Label Text="Username" CssClass="lblUsername" ID="lblUsername" runat="server" />
            <asp:TextBox CssClass="txtUsername" runat="server" ID="txtUsername" placeholder="Enter username" />
            <asp:Label Text="Password" CssClass="lblPassword" ID="lblPassword" runat="server" />
            <asp:TextBox CssClass="txtPassword" runat="server" ID="txtPassword" placeholder="Enter password" TextMode="Password" />
            <asp:Label Text="Repeat Password" CssClass="lblPassword" ID="lblRptPassword" runat="server" />
            <asp:TextBox CssClass="txtPassword" runat="server" ID="txtRptPassword" placeholder="Enter password again" TextMode="Password" />
            <asp:Label CssClass="lblCaptcha" ID="lblCaptcha" runat="server" />
            <asp:TextBox CssClass="txtCaptcha" ID="txtCaptcha" runat="server" />
            <asp:Button Text="Register" CssClass="btnLogin" ID="btnRegister" runat="server" OnClick="btnRegister_Click" />
            <asp:Button Text="Do you already have an account? Log In." CssClass="btnToLogin" ID="btnToLogin" runat="server" OnClick="btnToLogin_Click" />

        </form>
    </div>
</body>
</html>
