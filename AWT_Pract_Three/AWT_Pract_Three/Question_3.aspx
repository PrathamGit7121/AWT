<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_3.aspx.cs" Inherits="AWT_Pract_Three.Question_3" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>
                <asp:Label ID="Label1" runat="server" Text="LINQ to SQL"></asp:Label>
             </h1>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Enter Customer ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Enter Customer Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Enter Customer Address"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:TextBox ID="txtAddress0" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" Width="139px" />
            <br />
            <br />
            <asp:GridView ID="Stud_GridView" runat="server" Width="284px">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" Width="65px" OnClick="btnAdd_Click"  />
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="65px" />
            &nbsp;
            <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="65px"  />
            &nbsp;
            <br />
            <br />
            <asp:Label ID="Message_label" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
