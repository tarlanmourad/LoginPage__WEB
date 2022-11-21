<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LoginPage__WEB.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/style.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <img src="images/user.png" class="user" />
        <h2>Log In</h2>
        <form id="frmLogin" runat="server">
            <asp:Label Text="Username" CssClass="lblUsername" ID="lblUsername" runat="server" />
            <asp:TextBox CssClass="txtUsername" runat="server" ID="txtUsername" placeholder="Enter username" />
            <asp:Label Text="Password" CssClass="lblPassword" ID="lblPassword" runat="server" />
            <asp:TextBox CssClass="txtPassword" runat="server" ID="txtPassword" placeholder="Enter password" TextMode="Password" />
            <asp:Button Text="Log In" CssClass="btnLogin" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
            <asp:Button Text="Don't you have an account? Register now." CssClass="btnToRegister" ID="btnRegister" runat="server" OnClick="btnRegister_Click" />
        </form>
    </div>
</body>
</html>
