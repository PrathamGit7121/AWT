<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_8_2.aspx.cs" Inherits="AWT_Practial_Three.Practical3_8_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    <form id="form1" runat="server">
            <h3>Database access using Entity Framework</h3>
            <asp:Label ID="lblPid" runat="server" Text="Product Id :"></asp:Label>
            <asp:TextBox ID="txtPid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPname" runat="server" Text="Product Name : "></asp:Label>
            <asp:TextBox ID="txtPname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPcost" runat="server" Text="Product Cost :"></asp:Label>
            <asp:TextBox ID="txtPcost" runat="server"></asp:TextBox>
            <br />
            <br />
        <asp:GridView ID="gridProduct" runat="server">
        </asp:GridView>
            <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br />
        <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
    </form>
    </div>
</body>
</html>