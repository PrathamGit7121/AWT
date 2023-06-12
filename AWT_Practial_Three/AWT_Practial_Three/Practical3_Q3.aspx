<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q3.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q31" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
            <asp:TextBox ID="TxtSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <asp:Button ID="btnSearchSP" runat="server" Text="Search using Stored Procedure" Width="204px" OnClick="btnSearchSP_Click" />
            <br />
            <br />
            <asp:GridView ID="gvEmployeeDetails" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="btnAddSP" runat="server" Text="Add Using Stored Procedure" Width="268px" OnClick="btnAddSP_Click" />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
