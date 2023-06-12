<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_7.aspx.cs" Inherits="AWT_Practical_2nd.Question_7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="script/jquery-3.6.4.min.js"></script>
    <script>
        $(document).ready(function () {
            $("button").click(function () {
                var num1 = $("#num1").val();
                var num2 = $("#num2").val();
                var multi = parseInt(num1) * parseInt(num2);
                alert("Multiplication is : " + multi);
            });
        });
    </script>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter first number"></asp:Label>
            &nbsp;<input type="text" id="num1" placeholder="Enter first number"/><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Enter second number"></asp:Label>
            &nbsp;<input type="text" id="num2" placeholder="Enter Second number"/><br /><br />
            <button>CLick me</button>
         </div>
    </form>
</body>
</html>
