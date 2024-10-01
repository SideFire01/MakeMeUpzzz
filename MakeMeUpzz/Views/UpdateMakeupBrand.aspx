<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupBrand.aspx.cs" Inherits="MakeMeUpzz.Views.UpdateMakeupBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server">
        <h1>
            Brand Update Page
        </h1>
        <hr />
        <h2>Insert makeup brand id</h2>
        <h2><%=Request.QueryString["id"]%></h2>
        </div>
     <div>
         <asp:Label ID="Label1" runat="server" Text="Name :" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="updatembnametb" runat="server" Placeholder="new brand name"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="Label2" runat="server" Text="Rating :" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="updatembratetb" runat="server" Placeholder="New brand rating"></asp:TextBox>
     </div>
     <div>
         <br />
         <asp:Button ID="backto" runat="server" Text="Cancel" OnClick="backto_Click"/>
         <br />
         <asp:Button ID="updatebtn" runat="server" Text="Confirm" OnClick="updatebtn_Click1" />
     </div>
     <asp:Label ID="errorMsgLabel" runat="server" ForeColor="Red"></asp:Label>
   <hr />
</asp:Content>