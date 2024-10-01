<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="MakeMeUpzz.Views.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Transaction History Page</h1>
        <hr />
        <h3>All past transactions:</h3>
        <div>
            <asp:GridView ID="HeaderUser" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Trans Id" SortExpression="TransactionID" />
                    <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:TemplateField HeaderText="Options">
                        <ItemTemplate>
                            <asp:Button ID="TransactionDetailsButton" runat="server" Text="Details" CommandName="ViewDetails" CommandArgument='<%# Eval("TransactionID") %>' OnClick="TransactionDetailsButton_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <hr />
        <div>
            <asp:GridView ID="HeaderAdmin" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Trans Id" SortExpression="TransactionID" />
                    <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:TemplateField HeaderText="Options">
                        <ItemTemplate>
                            <asp:Button ID="TransactionDetailsButton" runat="server" Text="Details" CommandName="ViewDetails" CommandArgument='<%# Eval("TransactionID") %>' OnClick="TransactionDetailsButton_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <br
            <h3>Home button here</h3>
        <hr />
        <h3>Ewwo :3</h3>

    </form>
</body>
</html>
