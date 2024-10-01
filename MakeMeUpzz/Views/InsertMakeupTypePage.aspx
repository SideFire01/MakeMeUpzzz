<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertMakeupTypePage.aspx.cs" Inherits="MakeMeUpzz.Views.InsertMakeupTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="InsertMakeupTypeView" runat="server">
        <h1>Makeup Type Insertion Page</h1>
        <hr />
        <div>
            <asp:Label ID="MakeupTypeNameLbl" runat="server" Text="Makeup Type Name: " Style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="MakeupTypeNameTB" runat="server" Placeholder="makeup type"></asp:TextBox>
        </div>
        <hr />
       
        <div>
             <h4>Click to add new makeup type</h4>
            <asp:Button ID="InsertMakeupTypeBtn" runat="server" Text="Add" OnClick="InsertMakeupTypeBtn_Click" />
        </div>
         <div>
     <asp:Button ID="BackBtn" runat="server" Text="Home Page" OnClick="BackBtn_Click" />
 </div>
        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
        </div>
    </div>

</asp:Content>
