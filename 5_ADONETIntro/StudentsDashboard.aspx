<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsDashboard.aspx.cs" Inherits="_5_ADONETIntro.StudentsDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Manage Student</h2>
        <table>
            <tr>
                <td>RollNumber</td>
                <td>
                    <asp:TextBox ID="txtRollNumber" runat="server"></asp:TextBox>
                    <asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click" />
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Trainer</td>
                <td>
                   <%-- <asp:TextBox ID="txtTrainerId" runat="server"></asp:TextBox>--%>
                    <asp:DropDownList ID="ddlTrainer" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear Form" OnClick="btnClear_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <hr />
        <h2>All Students</h2>
        <asp:GridView ID="gvStudents" runat="server"></asp:GridView>
    </form>
</body>
</html>
