<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoL Manager</title>
    <style type="text/css">
        .auto-style1 {
            color: #0000FF;
        }
        .auto-style2 {
            color: #FF5050;
        }
        .auto-style3 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your first name?&nbsp;
        <asp:TextBox ID="firstNameTextbox" runat="server"></asp:TextBox>
    
    
        <br />
        <br />
        What is your last name?&nbsp;
        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Clickme" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </div>
    <h1>Head Line 1</h1>
    <h2>Head Line 2</h2>
    <h3>Head Line 3</h3>
    <h4>Head Line 4</h4>
    <h5>Head Line 5</h5>
    <h6>Head Line 6</h6>
    <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
        This text has no<span class="auto-style2"> Style</span><span class="auto-style1">.</span></p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            &nbsp;</p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            <a href="http://www.google.com/">Hyperlink</a></p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            &nbsp;</p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            Placeholder</p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            &nbsp;</p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/1231231.png" NavigateUrl="http://www.youtube.com/" Target="_blank">Link 2</asp:HyperLink>
        </p>
        <p style="font-family: Verdana, Geneva, Tahoma, sans-serif">
            &nbsp;</p>
        <table class="auto-style3">
            <tr>
                <td>X</td>
                <td>C9</td>
                <td>100T</td>
            </tr>
            <tr>
                <td>C9</td>
                <td>x</td>
                <td>1-0</td>
            </tr>
            <tr>
                <td>100T</td>
                <td>0-1</td>
                <td>x</td>
            </tr>
        </table>
    </form>
    <p>
        &nbsp;</p>
    <ol>
        <li>Item 1</li>
        <li>Item 2</li>
        <li>Item 3</li>
    </ol>
</body>
</html>
