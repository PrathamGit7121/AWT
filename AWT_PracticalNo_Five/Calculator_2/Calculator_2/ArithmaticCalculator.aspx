<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArithmaticCalculator.aspx.cs" Inherits="Calculator_2.ArithmaticCalculator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"></head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Text="Calculator"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Number 1 :"></asp:Label>
            <asp:TextBox ID="txtN1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Number 2 :"></asp:Label>
            <asp:TextBox ID="txtN2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="Result :"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnSub" runat="server" Text="Subtract" OnClick="btnSub_Click" />
            <asp:Button ID="btnMul" runat="server" Text="Multiply" OnClick="btnMul_Click" />
            <asp:Button ID="btnDiv" runat="server" Text="Divide" OnClick="btnDiv_Click" />
        </div>
    </form>
</body>
</html>

