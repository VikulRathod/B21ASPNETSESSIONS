<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DataTransferTechniques.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Create an account</h2>
        <table>
            <tr>
                <td>Name
                    <span style="color: red;">*</span>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        runat="server" ErrorMessage="Name is required"
                        Text="*"
                        ControlToValidate="txtName" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                        runat="server" ErrorMessage="Age is required"
                        ControlToValidate="txtAge" Text="*" ForeColor="Red" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server"
                        ErrorMessage="Age should be between 1 and 150"
                        ControlToValidate="txtAge" MinimumValue="1"
                        MaximumValue="150" Type="Integer" ForeColor="Red">
                    </asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                        runat="server" ErrorMessage="Email is required"
                        ControlToValidate="txtEmail" Text="*" ForeColor="Red" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator1" runat="server"
                        ErrorMessage="Invalid Email"
                        ControlToValidate="txtEmail"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ForeColor="Red">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Email</td>
                <td>
                    <asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server"
                        ErrorMessage="Email and Confirm Email should be same"
                        ControlToValidate="txtConfirmEmail" ForeColor="Red"
                        ControlToCompare="txtEmail" Operator="Equal">
                    </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Even Number</td>
                <td>
                    <asp:TextBox ID="txtEven" runat="server"></asp:TextBox>
                    <asp:CustomValidator ID="CustomValidator1" runat="server"
                        ErrorMessage="Enter valid even number only"
                        ControlToValidate="txtEven" ForeColor="Red"
                        OnServerValidate="CustomValidator1_ServerValidate"
                        ClientValidationFunction="evenNumberValidation"
                        EnableClientScript="true">
                    </asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnRegister" runat="server" Text="Register"
                        OnClick="btnRegister_Click" />
                </td>
            </tr>
        </table>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                ShowSummary="true" HeaderText="Page Errors" ForeColor="Red"/>
        </div>
    </form>
    <script>

        function evenNumberValidation(source, args) {
            var input = args.Value;
            if (input != undefined && input != '' && input != 'undefined') {
                if (!isNaN(input)) {
                    if (input % 2 == 0) {
                        args.IsValid = true;
                    }
                    else {
                        args.IsValid = false;
                    }
                }
                else {
                    args.IsValid = false;
                }
            }
            else {
                args.IsValid = false; // mandatory
            }
        }

    </script>
</body>
</html>
