<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_4_1.aspx.cs" Inherits="AWT_Practical_2nd.Question_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Student Details Form</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbalName" runat="server" Text="Enter Your Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" runat="server" ControlToValidate="txtName" ErrorMessage="Name is Required" ValidateRequestMode="Disabled"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Enter Your Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password Is Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblConfirmPass" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPass" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" ForeColor="Red" runat="server" ControlToValidate="txtConfirmPass" ControlToCompare="txtPassword" ErrorMessage="Password Didn't Match"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text="Enter Your Age"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidator1" ControlToValidate="txtAge" ForeColor="Red" ErrorMessage="Enter Age Between 18 to 40" MaximumValue="40" MinimumValue="18" runat="server"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text="Enter Email ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Valid Email ID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT"  PostBackUrl="~/Question_4_2.aspx" Width="126px" />
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
