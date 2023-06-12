<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewUsingAjax.aspx.cs" Inherits="AWT_PracticalNo_Four.GridViewUsingAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 282px; width: 768px">
            <br />
            <asp:Label ID="Label1" runat="server" Text="GridView Pagination with AJAX"></asp:Label>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="cid" DataSourceID="SqlDataSource1" PageSize="2">
                        <Columns>
                            <asp:BoundField DataField="cid" HeaderText="cid" ReadOnly="True" SortExpression="cid" />
                            <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                            <asp:BoundField DataField="cadd" HeaderText="cadd" SortExpression="cadd" />
                        </Columns>
                        <PagerSettings Mode="NextPreviousFirstLast" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:customer_info ConnectionString %>" OnSelecting="SqlDataSource1_Selecting1" SelectCommand="SELECT * FROM [customer_info]"></asp:SqlDataSource>
                    <br />
                    <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <br />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>

