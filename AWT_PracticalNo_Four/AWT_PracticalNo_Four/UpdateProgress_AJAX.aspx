<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProgress_AJAX.aspx.cs" Inherits="AWT_PracticalNo_Four.UpdateProgress_AJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#003399" Text="AJAX Extension -ScriptManager,UpdatePanel and UpdateProgress"></asp:Label></h1>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label2" runat="server" Text="Num1"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Num2"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            <asp:Label ID="Label4" runat="server" Text="Calculating Please wait.....!"></asp:Label>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <br />
                    <asp:Label ID="lbAdd" runat="server" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:Label ID="lbSub" runat="server" ForeColor="Lime"></asp:Label>
                    <br />
                    <asp:Label ID="lbMul" runat="server" ForeColor="Blue"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" style="height: 29px" Text="Calculate" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnCalculate" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
