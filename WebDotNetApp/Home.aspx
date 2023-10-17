<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs"
    Inherits="WebDotNetApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>First Web Form Page</h2>

            <table>
                <tr>
                    <td>Name</td>
                    <td>
                        <input type="text" id="txtName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCreate" runat="server" 
                            Text="Click Me !!!" OnClick="btnCreate_Click" CssClass="btn btn-primary"/>
                    </td>
                </tr>
            </table>

        </div>
    </form>

   <%-- <script>
        document.getElementById('txtName').value = 'Vihaan';
        document.getElementById('txtEmail').value = 'Vihaan@gmail.com';
    </script>--%>
</body>
</html>
