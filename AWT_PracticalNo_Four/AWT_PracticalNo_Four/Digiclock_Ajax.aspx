<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Digiclock_Ajax.aspx.cs" Inherits="AWT_PracticalNo_Four.Digiclock_Ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="Digital Clock using AJAX" ForeColor="#3333CC"></asp:Label></h1>
            <asp:ScriptManager ID="Script_Manager" runat="server"></asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="Update_Panel" runat="server">
                <ContentTemplate>
                    <br />
                    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="tmrDigiClock" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
            <br />
            <asp:Timer ID="tmrDigiClock" runat="server" Interval="1000" OnTick="tmrDigiClock_Tick"></asp:Timer>
        </div>
    </form>
</body>
</html>
