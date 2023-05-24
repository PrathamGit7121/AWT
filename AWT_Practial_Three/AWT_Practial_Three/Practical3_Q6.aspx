<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q6.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="LINQ Program To find Odd Number"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblInput" runat="server" Text="Input Data :"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblAns" runat="server" Text="Odd Number :"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSelectOdd" runat="server" Text="Select Odd Numbers" OnClick="btnSelectOdd_Click" />
        </div>
    </form>
</body>
</html>

