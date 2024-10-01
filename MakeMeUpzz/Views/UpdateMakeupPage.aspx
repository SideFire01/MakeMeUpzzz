<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupPage.aspx.cs" Inherits="MakeMeUpzz.Views.UpdateMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="UpdateMakeupView" runat="server">
     <h1>Mekup Details Update Page</h1>
        <hr />
     <h2><%=Request.QueryString["id"]%></h2>
     <hr />
     <div>
         <asp:Label ID="MakeupNameLbl" runat="server" Text="Makeup Name" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="MakeupNameTB" runat="server" Placeholder="new name"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="MakeupPriceLbl" runat="server" Text="Makeup Price" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="MakeupPriceTB" runat="server" Placeholder="new price"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="MakeupWeightLbl" runat="server" Text="Makeup Weight" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="MakeupWeightTB" runat="server" Placeholder="new weight"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="MakeupTypeIDLbl" runat="server" Text="Makeup Type ID" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="MakeupTypeIDTB" runat="server" Placeholder="new type id"></asp:TextBox>
     </div>
     <div>
         <asp:Label ID="MakeupBrandIDLbl" runat="server" Text="Makeup Brand ID" Style="font-weight: bold"></asp:Label>
         <asp:TextBox ID="MakeupBrandIDTB" runat="server" Placeholder="new brand id"></asp:TextBox>
     </div>
        <br />
     <div>
         <asp:Button ID="UpdateMakeupBtn" runat="server" Text="COnfirm" OnClick="UpdateMakeupBtn_Click"/>
     </div>
     <div>
         <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
     </div>
 </div>

</asp:Content>
