<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_3_3.aspx.cs" Inherits="AWT_Practical_2nd.Question_3_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#CCFFFF" BorderStyle="Double" ForeColor="#000066" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>
            <br />
            <br />
            <p>Selected Date is: </p><asp:Label ID="lblDate" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
