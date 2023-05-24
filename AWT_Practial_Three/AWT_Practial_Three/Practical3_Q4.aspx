<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical3_Q4.aspx.cs" Inherits="AWT_Practial_Three.Practical3_Q4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Data List
            <asp:DataList ID="DataList1" runat="server" DataKeyField="cid" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    cid:
                    <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                    <br />
                    cname:
                    <asp:Label ID="cnameLabel" runat="server" Text='<%# Eval("cname") %>' />
                    <br />
                    cadd:
                    <asp:Label ID="caddLabel" runat="server" Text='<%# Eval("cadd") %>' />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>" SelectCommand="SELECT * FROM [customer_info]"></asp:SqlDataSource>
            <br />
            Details View<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="cid" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="cid" HeaderText="cid" ReadOnly="True" SortExpression="cid" />
                    <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                    <asp:BoundField DataField="cadd" HeaderText="cadd" SortExpression="cadd" />
                </Fields>
            </asp:DetailsView>
            <br />
            Form View<asp:FormView ID="FormView1" runat="server" DataKeyNames="cid" DataSourceID="SqlDataSource1" AllowPaging="True" CellPadding="4" ForeColor="#333333">
                <EditItemTemplate>
                    cid:
                    <asp:Label ID="cidLabel1" runat="server" Text='<%# Eval("cid") %>' />
                    <br />
                    cname:
                    <asp:TextBox ID="cnameTextBox" runat="server" Text='<%# Bind("cname") %>' />
                    <br />
                    cadd:
                    <asp:TextBox ID="caddTextBox" runat="server" Text='<%# Bind("cadd") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    cid:
                    <asp:TextBox ID="cidTextBox" runat="server" Text='<%# Bind("cid") %>' />
                    <br />
                    cname:
                    <asp:TextBox ID="cnameTextBox" runat="server" Text='<%# Bind("cname") %>' />
                    <br />
                    cadd:
                    <asp:TextBox ID="caddTextBox" runat="server" Text='<%# Bind("cadd") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    cid:
                    <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                    <br />
                    cname:
                    <asp:Label ID="cnameLabel" runat="server" Text='<%# Bind("cname") %>' />
                    <br />
                    cadd:
                    <asp:Label ID="caddLabel" runat="server" Text='<%# Bind("cadd") %>' />
                    <br />

                </ItemTemplate>
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            </asp:FormView>
            <br />
            Grid View<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="cid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="cid" HeaderText="cid" ReadOnly="True" SortExpression="cid" />
                    <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                    <asp:BoundField DataField="cadd" HeaderText="cadd" SortExpression="cadd" />
                </Columns>
            </asp:GridView>
            <br />
            List View<asp:ListView ID="ListView1" runat="server" DataKeyNames="cid" DataSourceID="SqlDataSource1">
                <AlternatingItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                        </td>
                        <td>
                            <asp:Label ID="cnameLabel" runat="server" Text='<%# Eval("cname") %>' />
                        </td>
                        <td>
                            <asp:Label ID="caddLabel" runat="server" Text='<%# Eval("cadd") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:Label ID="cidLabel1" runat="server" Text='<%# Eval("cid") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="cnameTextBox" runat="server" Text='<%# Bind("cname") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="caddTextBox" runat="server" Text='<%# Bind("cadd") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        </td>
                        <td>
                            <asp:TextBox ID="cidTextBox" runat="server" Text='<%# Bind("cid") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="cnameTextBox" runat="server" Text='<%# Bind("cname") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="caddTextBox" runat="server" Text='<%# Bind("cadd") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                        </td>
                        <td>
                            <asp:Label ID="cnameLabel" runat="server" Text='<%# Eval("cname") %>' />
                        </td>
                        <td>
                            <asp:Label ID="caddLabel" runat="server" Text='<%# Eval("cadd") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                    <tr runat="server" style="">
                                        <th runat="server">cid</th>
                                        <th runat="server">cname</th>
                                        <th runat="server">cadd</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="">
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Label ID="cidLabel" runat="server" Text='<%# Eval("cid") %>' />
                        </td>
                        <td>
                            <asp:Label ID="cnameLabel" runat="server" Text='<%# Eval("cname") %>' />
                        </td>
                        <td>
                            <asp:Label ID="caddLabel" runat="server" Text='<%# Eval("cadd") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <br />
            Repeater<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
