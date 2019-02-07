<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoL Manager</title>
    </head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="usernameBox" runat="server">username</asp:TextBox>
        <br />
        <asp:TextBox ID="passwordBox" runat="server">password</asp:TextBox>
        <br />
        <asp:Button ID="logInButton" runat="server" Text="Log in" />
    </form>
</body>
</html>
