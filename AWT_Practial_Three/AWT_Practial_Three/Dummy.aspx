<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dummy.aspx.cs" Inherits="AWT_Practial_Three.Dummy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter Customer ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Customer Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter Customer Address"></asp:Label>
&nbsp;<asp:TextBox ID="TxtCAddress" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;
            <asp:TextBox ID="TxtSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" />
            <br />
            <br />
            <asp:GridView ID="gvCustomerDetails" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
        &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
&nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" />
&nbsp;
            <br />
            <asp:Label ID="MsgLabel" runat="server" Text=""></asp:Label>
        &nbsp;</div>
    </form>
</body>
<