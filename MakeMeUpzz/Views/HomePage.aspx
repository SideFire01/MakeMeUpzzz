<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MakeMeUpzz.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <h1>Home Page</h1>
    <hr />
    <h3>Hello :3:</h3>
    <asp:GridView ID="UserData" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="UserData_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="Id" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username"></asp:BoundField>
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail"></asp:BoundField>
            <asp:BoundField DataField="UserDOB" HeaderText="Dob" SortExpression="UserDOB"></asp:BoundField>
            <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender"></asp:BoundField>
            <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole"></asp:BoundField>
            <asp:BoundField DataField="UserPassword" HeaderText="Password" SortExpression="UserPassword"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
