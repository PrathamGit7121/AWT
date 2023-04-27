<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disconnected_Architecture.aspx.cs" Inherits="AWT_Pract_Three.Disconnected_architecture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table style="width: 361px">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label5" runat="server" Text="Enter Customer ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRollNo" runat="server" Width="193px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label6" runat="server" Text="Enter Customer Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="193px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label7" runat="server" Text="Enter Customer Address"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" Width="193px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style1"></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="txtSearch" runat="server" Width="137px"></asp:TextBox>
                    </td>
                    <td >
                        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="200px" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style1"></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="Stud_GridView" runat="server" Width="358px"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="65px" OnClick="btnAdd_Click" /></td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="65px" OnClick="btnDelete_Click" /></td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="65px" OnClick="btnUpdate_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td  colspan="3">
                        <asp:Label ID="Message_label" runat="server" Text="Result"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
