<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<script runat="server">
    void BtnClickme_Click(Object sender, EventArgs e)
    {
        lblClickme.Text = "Clicked me " + DateTime.Now.ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>No cs file</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblClickme" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Button ID="BtnClickme" runat="server" Text="Button" OnClick="BtnClickme_Click" />
        </div>
    </form>
</body>
</html>
