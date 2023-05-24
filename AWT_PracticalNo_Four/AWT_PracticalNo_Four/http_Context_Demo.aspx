<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="http_Context_Demo.aspx.cs" Inherits="AWT_PracticalNo_Four.http_Context_Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label3" runat="server" Text="Server side Session Management using Context.items" ForeColor="Red"></asp:Label></h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnStore" runat="server" Text="Store" OnClick="btnStore_Click" /></td>
                    <td>
                        <asp:Button ID="btnRetrive" runat="server" Text="Retrive" OnClick="btnRetrive_Click" /></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
