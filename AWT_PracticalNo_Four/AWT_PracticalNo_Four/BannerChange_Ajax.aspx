<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BannerChange_Ajax.aspx.cs" Inherits="AWT_PracticalNo_Four.BannerChange_Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Banner Change Using AJAX</h1>
            <asp:ScriptManager ID="Script_Manager" runat="server"></asp:ScriptManager><br />
            <asp:UpdatePanel ID="Update_Panal" runat="server">
                <ContentTemplate>
                    <asp:Image ID="myImage" runat="server" ImageUrl="~/img/FAMT1.jpg" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="tmrUpdateBanner" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel><br />
            <asp:Timer ID="tmrUpdateBanner" runat="server" Interval="3000" OnTick="tmrUpdateBanner_Tick"></asp:Timer>
        </div>
    </form>
</body>
</html>
