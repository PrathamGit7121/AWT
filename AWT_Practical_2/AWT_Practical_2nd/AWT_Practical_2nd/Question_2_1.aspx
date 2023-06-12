<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_2_1.aspx.cs" Inherits="AWT_Practical_2nd.Question_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter Your Name"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="btnPostBackPostiong" runat="server" Text="Same Page Post Back" OnClick="btnPostBackPostiong_Click" />
            <asp:Button ID="btnCrossPagePosting" runat="server" Text="Cross Page Post Back" PostBackUrl="~/Question_2_2.aspx"/>
            <br />
            <br />
            <asp:Label ID="content" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
