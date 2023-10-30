<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CachingDemo.aspx.cs" Inherits="DataTransferTechniques.CachingDemo" %>

<%--<%@ OutputCache Duration="60" VaryByParam="none" %>--%>

<%@ Register Src="~/CachingUserControl.ascx" TagPrefix="UC" TagName="CachingUC"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Page Loaded At: </h3>
            <asp:Label ID="lblTime" runat="server"></asp:Label>
        </div>

        <UC:CachingUC ID="CahincgUC" runat="server"/>
    </form>
</body>
</html>
