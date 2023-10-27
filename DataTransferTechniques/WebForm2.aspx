<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DataTransferTechniques.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Web Form 2 Page Content</h2>
            <table>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:Label ID="lblName" runat="server"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td>Email</td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnRedirect" runat="server" Text="Visit WebForm 1"
                            OnClick="btnRedirect_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
