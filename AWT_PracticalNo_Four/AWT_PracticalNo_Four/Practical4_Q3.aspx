<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical4_Q3.aspx.cs" Inherits="AWT_PracticalNo_Four.Practical4_Q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Client side Session anagement using Query String</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCounter" runat="server" Text="Counter:0"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Button" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
        </div>
    </form>
</body>
</html>
