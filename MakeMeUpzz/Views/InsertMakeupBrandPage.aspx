<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertMakeupBrandPage.aspx.cs" Inherits="MakeMeUpzz.Views.InsertMakeupBrandPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="InsertMakeupBrandView" runat="server">
    <h1>Makeup Brand Insertion Page</h1>
    <hr />
        <h3>Insert brand details below</h3>
    <div>
        <asp:Label ID="MakeupBrandNameLbl" runat="server" Text="Brand Name: " Style="font-weight: bold"></asp:Label>
        <asp:TextBox ID="MakeupBrandNameTB" runat="server" Placeholder="name"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="MakeupBrandRatingLbl" runat="server" Text="Brand Rating (0-100): " Style="font-weight: bold"></asp:Label>
        <asp:TextBox ID="MakeupBrandRatingTB" runat="server" Placeholder="online rating"></asp:TextBox>
    </div>            
    <div>
        <hr />
        <h4>Click to add new brand</h4>
        <asp:Button ID="InsertMakeupBrandBtn" runat="server" Text="Add Brand" OnClick="InsertMakeupBrandBtn_Click"/>
    </div>
         <div>
     <asp:Button ID="BackBtn" runat="server" Text="Home Page" OnClick="BackBtn_Click" />
 </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
</div>

</asp:Content>
