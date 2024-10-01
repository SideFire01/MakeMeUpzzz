<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="MakeMeUpzz.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>Profile Settings Page</h1>
    <div>
        <hr />
         <h3>Details Editor</h3>
        <h4>Please provide new credentials here</h4>
        <div>
    <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
        </div>
        <br />
        <div>
            <asp:Label ID="usernameLabel" runat="server" Text="Username: " Style="font-weight: bold" />
            <asp:TextBox ID="usernameRegister" runat="server" Placeholder="new username"/>
        </div>
         <div>
            <asp:Label ID="emailLabel" runat="server" Text="Email: " Style="font-weight: bold" />
            <asp:TextBox ID="emailRegister" runat="server" Placeholder="new email"/>
        </div>
         <div>
            <asp:RadioButton ID="male" runat="server" Text="Male" GroupName="gender"/>
            <asp:RadioButton ID="female" runat="server" Text="Female" GroupName="gender"/>
        </div>
        
        <br />
        <div>
            <asp:Button ID="UpdateButton" runat="server" Text="Confirm" OnClick="UpdateButton_Click" Style="font-weight: bold"/>
        </div>

        <div>
            <asp:Label ID="updateerror" runat="server" Text=""></asp:Label>
        </div>
</div>  
    <hr />

    <div>
        <h3>Password Updater</h3>
        <h4>Please provide your old and new password, becareful of typos</h4>
         <div>
     <asp:Label ID="passwordLabel" runat="server" Text="Old Password: " Style="font-weight: bold"/>
     <asp:TextBox ID="passwordRegister" runat="server" Placeholder="old password here" TextMode="Password" />
 </div>
 <div>
     <asp:Label ID="newpassword" runat="server" Text="New Password: " Style="font-weight: bold"/>
     <asp:TextBox ID="newpasswordrupdate" runat="server" Placeholder="new password here" TextMode="Password" />
 </div>
        <br />
        <div>
            <asp:Button ID="updatepassword" runat="server" Text="Confirm" OnClick="updatepassword_Click" />
        </div>
        <div>
            <asp:Label ID="passerr" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
