<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagination_AJAX.aspx.cs" Inherits="AWT_PracticalNo_Four.Pagination_AJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Paging Using AJAX</h1>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="grid_view" runat="server" AllowPaging="True" PageSize="2" AutoGenerateColumns="False" DataKeyNames="cid" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="cid" HeaderText="cid" ReadOnly="True" SortExpression="cid" />
                            <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                            <asp:BoundField DataField="cadd" HeaderText="cadd" SortExpression="cadd" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:customer_info ConnectionString %>" ProviderName="<%$ ConnectionStrings:customer_info ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [customer_info]"></asp:SqlDataSource>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="tmrPaging" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel><br />
            <asp:Timer ID="tmrPaging" runat="server" Interval="5000" OnTick="tmrPaging_Tick"></asp:Timer>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
