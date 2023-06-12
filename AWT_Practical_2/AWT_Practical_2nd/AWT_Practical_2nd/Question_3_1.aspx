<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question_3_1.aspx.cs" Inherits="AWT_Practical_2nd.Question_3_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
            <br />
            <br />
            <asp:Label ID="lblUploadStatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
