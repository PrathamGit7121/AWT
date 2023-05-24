<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q7.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    <form id="form1" runat="server">
            <asp:Label ID="lblEid" runat="server" Text="Employee Id :"></asp:Label>
            <asp:TextBox ID="txtEid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Employee Name : "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDesg" runat="server" Text="Designation :"></asp:Label>
            <asp:TextBox ID="txtDesg" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Salary :"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            <br />
        <asp:GridView ID="gridEmployee" runat="server">
        </asp:GridView>
        <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        &nbsp;<asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        &nbsp;<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </form>
    </div>
</body>
</html>

