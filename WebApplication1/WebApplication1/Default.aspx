<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoL Manager</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="usrPwd">Username</div>
            <asp:TextBox ID="usernameBox" CssClass="box" runat="server"></asp:TextBox>
            <br />
            <div class="usrPwd">Password</div>
            <asp:TextBox ID="passwordBox" CssClass="box" runat="server"></asp:TextBox>
            <br />
            <br />
        <img class="LEC" src="LEC-2019.png" />
        <img class="LCS" src="lcs.png" />
        <img class="LCK" src="LCK.png" />
            <asp:Button ID="signInButton" CssClass="signInButton" runat="server" Text="Sign In" />
            <asp:Button ID="signUpButton" CssClass="signUpButton" runat="server" Text="Sign Up" />
    </form>
</body>
</html>
