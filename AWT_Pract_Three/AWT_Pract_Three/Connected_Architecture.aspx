<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connected_Architecture.aspx.cs" Inherits="AWT_Pract_Three.Insert_DB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Enter Customer ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRollNo" ErrorMessage="Enter Valid Roll No" ForeColor="Red" MaximumValue="30" MinimumValue="1"></asp:RangeValidator>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Enter Customer Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ForeColor="Red" ErrorMessage="Enter Student Name"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Enter Customer Address"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAddress" ForeColor="Red" ErrorMessage="Enter Student Address"></asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtSearch" ErrorMessage="Enter Roll No. Only" ForeColor="Red" MaximumValue="30" MinimumValue="1"></asp:RangeValidator>
            <br />
            <br />
            <asp:GridView ID="Stud_GridView" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"/>
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            &nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
            &nbsp;
            <br />
            <br />
            <asp:Label ID="Message_label" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
