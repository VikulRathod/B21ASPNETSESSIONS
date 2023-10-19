<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebDotNetApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h2>Login</h2>
        <table>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" 
                        OnTextChanged="txtEmail_TextChanged"
                        AutoPostBack="true"></asp:TextBox>
                    <asp:Label ID="lblEmail" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CheckBox ID="cbAction" runat="server" 
                        OnCheckedChanged="cbAction_CheckedChanged"
                        AutoPostBack="true"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Log In" />
                </td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Clear" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
