<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorPage.aspx.cs" Inherits="DataTransferTechniques.CalculatorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hiddenNumber" runat="server" Value="1"/>
        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
        <asp:Button ID="btnIncrement" runat="server" Text="Increment Number" 
            OnClick="btnIncrement_Click"/>
    </form>
</body>
</html>
