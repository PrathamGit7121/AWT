<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_4_2.aspx.cs" Inherits="AWT_Practical_2nd.Question_4_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Your Details</h1>
            <table>
                <tr>
                    <td>Name :</td>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Age :</td>
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Email :</td>
                    <td>
                        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
