<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="MakeMeUpzz.Views.TransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Transaction Details Page</h1>
        <hr />
        <h3>Here are your transaction details</h3>
        <div>
            <asp:GridView ID="DetailUser" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Trans Id" SortExpression="TransactionID" />
                    <asp:BoundField DataField="MakeupID" HeaderText="Product ID" SortExpression="MakeupID" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>

            </asp:GridView>
        </div>
        <br />
        <hr />
        <div>
            <asp:GridView ID="DetailAdmin" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Trans ID" SortExpression="TransactionID" />
                    <asp:BoundField DataField="MakeupID" HeaderText="Product ID" SortExpression="MakeupID" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
