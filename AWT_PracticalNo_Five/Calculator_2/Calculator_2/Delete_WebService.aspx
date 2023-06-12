<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_WebService.aspx.cs" Inherits="Calculator_2.Delete_WebService" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
</head>
<body>
 <form id="form1" runat="server">
 <div>
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="Delete Product Details"></asp:Label>
     <asp:GridView ID="gvproduct" runat="server">
     </asp:GridView>
     <br />
     <asp:Label ID="Label2" runat="server" Text="Product ID :"></asp:Label>
     <asp:TextBox ID="txtPid" runat="server"></asp:TextBox>
     <br />
     <asp:Label ID="Label3" runat="server" Text="Product Name :"></asp:Label>
     <asp:TextBox ID="txtPname" runat="server"></asp:TextBox>
     <br />
     <asp:Label ID="Label5" runat="server" Text="Product Details :"></asp:Label>
     <asp:TextBox ID="txtPdetails" runat="server"></asp:TextBox>
     <br />
     <asp:Label ID="Label4" runat="server" Text="Product Price :"></asp:Label>
     <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
     <br />
     <br />
     <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
 </div>
 </form>
</body>
</html>

