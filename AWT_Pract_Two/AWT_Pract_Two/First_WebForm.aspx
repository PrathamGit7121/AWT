<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First_WebForm.aspx.cs" Inherits="AWT_Pract_Two.First_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <asp:Label ID="Title" runat="server" style="font-size: 30px" Text="Find Factorial" Font-Bold="True"></asp:Label>
                <br />
                <br />
                <asp:Label ID="txtLabel" runat="server" Text="Enter a Number : "></asp:Label>
                <asp:TextBox ID="txtInput" runat="server" Width="200px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="txtResul" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnFactorial" runat="server" Text="Factorial" Font-Bold="True" Height="34px" OnClick="btnFactorial_Click" Width="155px" />
            </center>
        </div>
    </form>
</body>
</html>
