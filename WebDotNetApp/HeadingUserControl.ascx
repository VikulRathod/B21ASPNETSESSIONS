<%@ Control Language="C#" AutoEventWireup="true"
    CodeBehind="HeadingUserControl.ascx.cs"
    Inherits="WebDotNetApp.HeadingUserControl" %>

<%@ Register Src="~/NavLinksUserControl.ascx" TagPrefix="navUC" TagName="NavLinks" %>

<div style="padding: 20px; width: 100%; display: inline;">
    <asp:Image runat="server" ImageUrl="~/Images/justlogo.png"
        Height="30px" Width="30px"
        AlternateText="site logo" />
    <span>Welcome to VHaaSh Technologies Pvt Ltd</span>

    <%--<div style="float: right;">--%>
    <div>
        <navUC:NavLinks ID="navs" runat="server" />
    </div>
</div>
