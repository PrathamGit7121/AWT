<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_9.aspx.cs" Inherits="AWT_Practical_2nd.Question_9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="script/angular.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div ng-app="">
             <h1>Adding</h1>
            <asp:TextBox ID="TextBox1" type="number" ng-model="num1" runat="server"></asp:TextBox><br /><br />
            <asp:TextBox ID="TextBox2" type="number" ng-model="num2" runat="server"></asp:TextBox><br /><br />
            <p>The sum is: {{ num1 + num2 }}</p> 
        </div>
    </form>
</body>
</html>
