<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs"
    MasterPageFile="~/MySite.Master" Inherits="WebDotNetApp.signin" %>

<asp:Content ID="side" runat="server" ContentPlaceHolderID="sideMenu">
    <ul style="list-style-type: none; direction: revert">
        <li><a href="">Menu 1</a></li>
        <li><a href="">Menu 2</a></li>
        <li><a href="">Menu 3</a></li>
        <li><a href="">Menu 4</a></li>
    </ul>
</asp:Content>


<asp:Content ID="signin" runat="server" ContentPlaceHolderID="mainContent">
    <h2>Sign In Page Content</h2>
    <form id="signInForm" runat="server">
        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Email address</label>
            <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="name@example.com">
        </div>
        <div class="mb-3">
            <label for="exampleFormControlInput1" class="form-label">Password</label>
            <input type="email" class="form-control" id="exampleFormControlInput1" placeholder="enter password">
        </div>
        <div class="mb-3">
            <input type="submit" value="Sign In" class="btn btn-info form-control" />
        </div>
    </form>

        <asp:HyperLink ID="signup" runat="server"
        NavigateUrl="~/SignUp.aspx">Sign Up</asp:HyperLink>
</asp:Content>
