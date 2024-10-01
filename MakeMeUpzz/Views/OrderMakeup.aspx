<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="MakeMeUpzz.Views.OrderMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
    <h1>Product Order Page</h1>
    <hr />
    <h3>Product Catalog</h3>
        <asp:GridView ID="MakeUpGV" AutoGenerateColumns="false" runat="server" OnRowCommand="MakeUpGV_RowCommand" DataKeyNames="MakeupID">
    <Columns>
        <asp:BoundField DataField="MakeupID" HeaderText="Id" SortExpression="MakeupID"></asp:BoundField>
        <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName"></asp:BoundField>
        <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice"></asp:BoundField>
        <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight"></asp:BoundField>
        <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName"></asp:BoundField>
        <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName"></asp:BoundField>
        <asp:TemplateField HeaderText="Amount">
            <ItemTemplate>
                <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Options">
            <ItemTemplate>
                <asp:Button ID="btnOrder" runat="server" Text="Order" CommandName="Order" CommandArgument='<%# Container.DataItemIndex %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    <hr />
    <h5>Click to confirm order</h5>
    <asp:Button ID="CheckoutButton" runat="server" Text="Confirm Order" OnClick="CheckoutButton_Click" />
    <br />
    <h5>Click to clear cart items</h5>
    <asp:Button ID="cleartransaction" runat="server" Text="Empty Cart" OnClick="cleartransaction_Click" />
</asp:Content>
