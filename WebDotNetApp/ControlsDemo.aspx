<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlsDemo.aspx.cs"
    Inherits="WebDotNetApp.ControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Controls Demo</h2>
            <table>
                <tr>
                    <td>
                        <input type="button" value="HTML BUTTON" />
                    </td>
                    <td>
                        <asp:Button ID="btn1" runat="server" Text="ASP BUTTON" />
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"
                            TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                   <%-- <td>
                        <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="Gender" />
                        <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="Gender" />
                    </td>--%>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server" 
                            RepeatDirection="Horizontal" TextAlign="Left">
                            <%--<asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                            <asp:ListItem Value="Female" Text="Female"></asp:ListItem>--%>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>Education</td>
                    <%--<td>
                        <asp:CheckBox ID="cbSSC" runat="server" Text="SSC" />
                        <asp:CheckBox ID="cbHSC" runat="server" Text="HSC" />
                        <asp:CheckBox ID="cbDiploma" runat="server" Text="Diploma" />
                        <asp:CheckBox ID="cbDegree" runat="server" Text="Degree" />
                    </td>--%>
                    <td>
                        <asp:CheckBoxList ID="cblEducation" runat="server" RepeatDirection="Horizontal">
                            <%--<asp:ListItem Value="SSC" Text="SSC"></asp:ListItem>
                            <asp:ListItem Value="HSC" Text="HSC"></asp:ListItem>
                            <asp:ListItem Value="DIPLOMA" Text="DIPLOMA"></asp:ListItem>
                            <asp:ListItem Value="DEGREE" Text="DEGREE"></asp:ListItem>--%>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server">
                            <%--<asp:ListItem Value="-1" Text="-- Select City --"></asp:ListItem>
                            <asp:ListItem Value="1" Text="Pune"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Mumbai"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Delhi"></asp:ListItem>--%>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnGet" runat="server" Text="Get All Values" OnClick="btnGet_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnSet" runat="server" Text="Set Default Values" OnClick="btnSet_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl="http://www.google.com"
                            Target="_blank">
                            Visit Google</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Image ID="Image1" runat="server"
                            ImageUrl="~/Images/3.jpg" Height="100px" Width="180px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
