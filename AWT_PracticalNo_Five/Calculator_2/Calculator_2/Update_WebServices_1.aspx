<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_WebServices_1.aspx.cs" Inherits="Calculator_2.Update_WebServices_1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
</head>
<body>
 <form id="form1" runat="server">
 <div>
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="Update Product Details"></asp:Label>
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
     <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
 </div>
 </form>
</body>
</html>
