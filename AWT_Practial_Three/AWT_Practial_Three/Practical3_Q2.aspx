<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q2.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Enter Employee ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtEid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter Employee Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtEName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter Designation"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtEDesignation" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Enter Salary"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TxtESalary" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;
            <asp:TextBox ID="TxtSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br />
            <br />
            <asp:GridView ID="gvEmployeeDetails" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        &nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
&nbsp;
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
&nbsp;
            <br /><br />
            <asp:Label ID="MsgLabel" runat="server" Text=""></asp:Label>
        <div>
        </div>
    </form>
</body>
</html>
