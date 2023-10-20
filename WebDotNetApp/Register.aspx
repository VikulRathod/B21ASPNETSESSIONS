<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebDotNetApp.Register" %>

<%@ Register Src="~/HeadingUserControl.ascx" TagPrefix="muc" TagName="HeadingUC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <muc:HeadingUC runat="server" ID="heading"/>
    <form id="form1" runat="server">
        <div>
            <h2>Create an account</h2>
            <table>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Confirm Password</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server"
                            TextMode="Password">
                        </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Sign Up" />
                    </td>
                    <td>
                        <asp:Button ID="btnClear" runat="server" Text="Clear" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:HyperLink NavigateUrl="~/Login.aspx" runat="server">
                            Already registered? login</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
