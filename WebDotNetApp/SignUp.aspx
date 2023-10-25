<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" 
    MasterPageFile="~/MySite.Master"
    Inherits="WebDotNetApp.SignUp" %>


<asp:Content ID="signupcontent" runat="server" ContentPlaceHolderID="mainContent">
    <h2>Sign Up Page Content</h2>

    <asp:HyperLink ID="signin" runat="server"
        NavigateUrl="~/signin.aspx">Sign In</asp:HyperLink>
</asp:Content>