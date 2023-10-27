<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Views.aspx.cs" Inherits="DataTransferTechniques.Views" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Total Views: </h3>
            <asp:Label ID="lblTotalViews" runat="server"></asp:Label>
            <h3>Unique Views: </h3>
            <asp:Label ID="lblUniqueViews" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
