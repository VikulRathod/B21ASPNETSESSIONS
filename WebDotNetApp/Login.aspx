<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebDotNetApp.Login" %>

<%@ Register Src="~/HeadingUserControl.ascx" TagPrefix="muc" TagName="HeadingUC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</head>
<body>

    <div class="row">
        <div class="col-8">
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
                                AutoPostBack="true" />
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
                    <tr>
                        <td colspan="2">
                            <asp:HyperLink runat="server" NavigateUrl="~/Register.aspx">
                        New user? Register</asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <input type="button" value="HTML BUTTON" onclick="fun1()" />
                        </td>
                        <td>
                            <input type="text" id="txtAddress" runat="server" />
                        </td>
                    </tr>
                </table>
                <script>
                    function fun1() {
                        alert('button clicked');
                    }
                </script>
            </form>
        </div>
        <div class="col-4">
            <muc:HeadingUC ID="heading" runat="server" />
        </div>
    </div>

</body>
</html>
