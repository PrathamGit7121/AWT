<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q1.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Database access using Entity Framework</h3>
            <asp:Label ID="Label1" runat="server" Text="Product Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Product Cost"></asp:Label>
&nbsp;<asp:TextBox ID="TxtCAddress" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;
            <asp:TextBox ID="TxtSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
            <br />
            <asp:GridView ID="gvCustomerDetails" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="MsgLabel" runat="server" Text=""></asp:Label>
        &nbsp;<br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;
            <br />
        </div>
    </form>
</body>
</html>

