<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDashboard.aspx.cs" Inherits="_3_EFDBFirstAppraoch_CRUD.StudentDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Student Dashboard</h2>
        <asp:HyperLink ID="linkTrainers" runat="server" NavigateUrl="~/TrainerDashboard.aspx">Manage Trainers</asp:HyperLink>
        <hr />

        <table>
            <tr>
                <td>Roll Number</td>
                <td>
                    <asp:TextBox ID="txtRollNumber" runat="server"></asp:TextBox>
                    <asp:Button ID="btnLoadStudent" runat="server" Text="Load Student" OnClick="btnLoadStudent_Click" />
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
                    <asp:RadioButtonList ID="rblGender" runat="server">
                        <asp:ListItem ID="rbMale" Value="Male" Text="Male"></asp:ListItem>
                        <asp:ListItem ID="rbFemale" Value="Female" Text="Female"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Trainer</td>
                <td>
                    <asp:TextBox ID="txtTrainerId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <hr />
        <asp:GridView ID="gvStudents" runat="server"></asp:GridView>
    </form>
</body>
</html>
