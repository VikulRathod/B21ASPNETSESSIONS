<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs"
    MasterPageFile="~/MySiteMaster.Master"
    Inherits="DataTransferTechniques.Create" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="MUC" TagName="MyUserControl" %>

<asp:Content ID="pageContent" runat="server" ContentPlaceHolderID="mainContent">
    <div style="width: 100%; padding: 50px; border: 1px solid red;">
        <h2>Create Web Form Content</h2>
        <asp:TextBox ID="txtWebForm" runat="server"></asp:TextBox>
        <asp:Button ID="btnWebForm" runat="server" Text="Web Form Button" OnClick="btnWebForm_Click"/>
        <br />
        <MUC:MyUserControl ID="myUserControl1" runat="server" />
    </div>
</asp:Content>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 100%; padding: 50px; border: 1px solid red;">
            <h2>Create Web Form Content</h2>
            <MUC:MyUserControl ID="myUserControl" runat="server" />
        </div>
    </form>
</body>
</html>--%>


