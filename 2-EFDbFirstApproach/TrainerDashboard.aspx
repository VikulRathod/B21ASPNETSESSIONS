<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrainerDashboard.aspx.cs" Inherits="_2_EFDbFirstApproach.TrainerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>All Trainers</h2>
        <hr />
        Id:
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnLoad" runat="server" Text="Search" OnClick="btnLoad_Click" />

        <hr />
        <asp:GridView ID="gvTrainers" runat="server"></asp:GridView>
    </form>
</body>
</html>
