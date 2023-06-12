<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display_GridView_2.aspx.cs" Inherits="Calculator_2.Display_GridView_2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
</head>
<body>
 <form id="form1" runat="server">
 <div>
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="Insert Employee Details"></asp:Label>
     <asp:GridView ID="gvemp" runat="server">
     </asp:GridView>
     <br />
     <asp:Label ID="Label2" runat="server" Text="Employee ID :"></asp:Label>
     <asp:TextBox ID="txtEid" runat="server"></asp:TextBox>
     <br />
     <asp:Label ID="Label3" runat="server" Text="Employee Name :"></asp:Label>
     <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
     <br />
     <asp:Label ID="Label4" runat="server" Text="Employee Salary :"></asp:Label>
     <asp:TextBox ID="txtEsalary" runat="server"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
     <br />
     <br />
     <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
 </div>
 </form>
</body>
</html>
