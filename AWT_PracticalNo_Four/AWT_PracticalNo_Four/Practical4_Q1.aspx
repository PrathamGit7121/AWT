<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical4_Q1.aspx.cs" Inherits="AWT_PracticalNo_Four.Practical4_Q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
            <h1>Client Side Session Management using Hiddent Fields</h1>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hidFieldCount" runat="server" OnValueChanged="Page_Load" Value="1" />
            <br />
            <asp:Button ID="btnVisitAgain_Click" runat="server" Text="Button" OnClick="btnVisitAgain_Click_Click" PostBackUrl="~/Practical4_Q1.aspx" />
            <br />
            <br />
            <asp:Label ID="lblVisitAgain" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
