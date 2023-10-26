<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="DataTransferTechniques.WebUserControl1" %>

<div style="padding:30px;border:1px solid black;">
    <h2>User Control Content</h2>
    <asp:TextBox ID="txtUC" runat="server"></asp:TextBox>
    <asp:Button ID="btnUC" runat="server" OnClick="btnUC_Click" Text="UC Button"/>
</div>