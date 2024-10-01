<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupTypePage.aspx.cs" Inherits="MakeMeUpzz.Views.UpdateMakeupTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="UpdateMakeupTypeView" runat="server">
    <h1>Makeup Type Update Page</h1>
        <hr />
    <h2><%=Request.QueryString["id"]%></h2>
    <hr />
    <div>
        <asp:Label ID="MakeupTypeNameLbl" runat="server" Text="Makeup Type Name: " Style="font-weight: bold"></asp:Label>
        <asp:TextBox ID="MakeupTypeNameTB" runat="server" Placeholder="new type name"></asp:TextBox>
    </div>
    <div>
        <br />
        <asp:Button ID="UpdateMakeupTypeBtn" runat="server" Text="Confirm" OnClick="UpdateMakeupTypeBtn_Click" Style="font-weight: bold"/>
    </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
</div>

</asp:Content>
