<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataTransferTechniques.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Web Form 1 Page Content</h2>
            <table>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnRedirect" runat="server" 
                            Text="Visit WebForm 2" OnClick="btnRedirect_Click"/>
                    </td>
                    <td>
                        <asp:Button ID="btnGoogle" runat="server" 
                            Text="Visit GOOGLE" OnClick="btnGoogle_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
