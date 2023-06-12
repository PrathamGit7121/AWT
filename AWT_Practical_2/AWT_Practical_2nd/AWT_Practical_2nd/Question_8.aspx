<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_8.aspx.cs" Inherits="AWT_Practical_2nd.Question_8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript" src ="//ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div ng-app="">
            <asp:TextBox ID="TextBox1" ng-model="txt" runat="server"></asp:TextBox><br /><br />
            <h1>Hi, {{txt}}</h1>
        </div>
        <asp:Label ID="label1" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
