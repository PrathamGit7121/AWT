<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="AWT_PracticalNo_Four.Application" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lblVisitorCoutn" Text="Label" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label runat="server" ID="lblOnlineVisitorCounter" Text="Label" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Clear" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
