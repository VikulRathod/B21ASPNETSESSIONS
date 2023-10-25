<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dummy.aspx.cs" Inherits="WebDotNetApp.Parent.Child.Dummy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Relative Paths</h2>

            <asp:HyperLink ID="linkFile" runat="server"
                NavigateUrl="~/Files/Company/CERTIFICATE_OF_INCORPORATION.PDF"
                Target="_blank">Show Document</asp:HyperLink>
        </div>
    </form>
</body>
</html>
