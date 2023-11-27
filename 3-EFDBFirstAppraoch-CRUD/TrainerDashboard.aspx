<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainerDashboard.aspx.cs" Inherits="_3_EFDBFirstAppraoch_CRUD.TrainerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Trainer Dashborad</h2>
        <hr />
        <table>
            <tr>
                <td>Trainer Id</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    <asp:Button ID="btnLoad" runat="server" Text="Load Trainer" OnClick="btnLoad_Click" />
                </td>
            </tr>
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
                <td>City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click"/> |
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
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
