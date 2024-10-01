<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertMakeup.aspx.cs" Inherits="MakeMeUpzz.Views.InsertMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="InsertMakeupView" runat="server">
        <h1>Makeup Insertion Page</h1>
        <hr />
        <div>
            <h3>Insert Product Details here</h3>
        </div>
        <div>
            <asp:Label ID="MakeupNameLbl" runat="server" Text="Makeup Name: " Style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="MakeupNameTB" runat="server" OnTextChanged="MakeupNameTB_TextChanged" Placeholder="name"></asp:TextBox>
        </div>
        
        <div>
            <asp:Label ID="MakeupPriceLbl" runat="server" Text="Makeup Price: " Style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="MakeupPriceTB" runat="server" OnTextChanged="MakeupPriceTB_TextChanged" Placeholder="price"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="MakeupTypeIDLbl" runat="server" Text="Makeup Type (ID): " Style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="MakeupTypeIDTB" runat="server"  Placeholder="type id"></asp:TextBox>
</div>

<div>
    <asp:Label ID="MakeupBrandIDLbl" runat="server" Text="Makeup Brand (ID): " Style="font-weight: bold"></asp:Label>
    <asp:TextBox ID="MakeupBrandIDTB" runat="server" OnTextChanged="MakeupBrandIDTB_TextChanged" Placeholder="brand id"></asp:TextBox>
</div>
        <div>
            <asp:Label ID="MakeupWeightLbl" runat="server" Text="Makeup Weight (gr): " Style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="MakeupWeightTB" runat="server" Placeholder="weight"></asp:TextBox>
        </div>

        
        <br />
        <h4>Click to add new makeup item</h4>
        <div>
            <asp:Button ID="InsertMakeupBtn" runat="server" Text="Add" OnClick="InsertMakeupBtn_Click" />
        </div>
        <hr />
        <div>
            <asp:Button ID="BackBtn" runat="server" Text="Home Page" OnClick="BackBtn_Click" />
        </div>

        <div>
            <asp:Label ID="ErrLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
