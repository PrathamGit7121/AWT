<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q5.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInput" runat="server" Text="Input Data :"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblWords" runat="server" Text="Short Words < 5 Character :"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSelect" runat="server" Text="Select Words" OnClick="btnSelect_Click" />
        </div>
    </form>
</body>
</html>
