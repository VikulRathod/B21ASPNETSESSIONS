<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CachingUserControl.ascx.cs" Inherits="DataTransferTechniques.CachingUserControl" %>

<%@ OutputCache Duration="60" VaryByParam="none" %>

<div style="width: 50%; padding: 50px; background-color: gray;">
    <h3>User Control Loaded At: </h3>
    <asp:Label ID="lblUCTime" runat="server"></asp:Label>

</div>
