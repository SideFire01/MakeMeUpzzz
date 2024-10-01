<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHandler.aspx.cs" Inherits="MakeMeUpzz.Views.TransactionHandler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Order Management Page</h1>
    <hr />
    <form id="form1" runat="server">
        <div>
            <h3>Please remember to handle orders frequently</h3>
            <asp:GridView ID="thgv" runat="server" AutoGenerateColumns="false" OnRowEditing="thgv_RowEditing">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction Id" SortExpression="TransactionID"></asp:BoundField>
                    <asp:BoundField DataField="UserID" HeaderText="Customer Id" SortExpression="Customer Id"></asp:BoundField>
                    <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate"></asp:BoundField>
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
                    <asp:CommandField ShowCancelButton="False" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Options"></asp:CommandField>
                </Columns>
            </asp:GridView>

        </div>
        <hr />
    </form>
</body>
</html>
