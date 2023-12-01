<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainerDashboard.aspx.cs" Inherits="EFCodeFirstApproach.TrainerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <h2>Trainer Dashboard</h2>
        <hr />
        <table>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Experience</td>
                <td>
                    <asp:TextBox ID="txtExperience" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <hr />
        <asp:GridView ID="gvTrainers" runat="server"></asp:GridView>
    </form>
</body>
</html>
