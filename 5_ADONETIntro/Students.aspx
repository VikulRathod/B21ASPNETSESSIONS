<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="_5_ADONETIntro.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Students List</h2>

            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:Button ID="btnLoad" runat="server" Text="Search" OnClick="btnLoad_Click"/>
            <hr />
            <asp:GridView ID="gvStudents" runat="server"></asp:GridView>

            <hr />
            <h2>Trainers List</h2>
            <asp:GridView ID="gvTrainers" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
