<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="_5_ADONETIntro.Location" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select Location</h2>
            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                <asp:ListItem Value="-1" Text="-- Select Country --"></asp:ListItem>
            </asp:DropDownList> |
            <asp:DropDownList ID="ddlState" runat="server" Enabled="false"
                AutoPostBack="true"
                OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
                <asp:ListItem Value="-1" Text="-- Select State --"></asp:ListItem>
            </asp:DropDownList> | 
            <asp:DropDownList ID="ddlCity" runat="server" Enabled="false"
                AutoPostBack="true"
                OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                <asp:ListItem Value="-1" Text="-- Select City --"></asp:ListItem>
            </asp:DropDownList>
        </div>

        <hr />
        <asp:Label ID="lblLocation" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
