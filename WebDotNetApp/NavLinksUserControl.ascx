<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavLinksUserControl.ascx.cs" Inherits="WebDotNetApp.NavLinksUserControl" %>

<style>
    ul li{
        /*display:inline;*/
        padding:10px;
    }

    ul li a{
        text-decoration:none;
    }
</style>

<ul style="list-style-type:none;">
    <li>
        <asp:HyperLink runat="server" ID="login" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
    </li>
     <li>
        <asp:HyperLink runat="server" ID="register" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
    </li>
</ul>