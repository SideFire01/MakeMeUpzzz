<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MakeMeUpzz.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <h1>User Login Page</h1>
            <hr />
            <h3>Enter credentials here</h3>
        <div>
            <asp:Label ID="usernameLabel" runat="server" Text="Username: " Style="font-weight: bold" />
            <asp:TextBox ID="usernameLogin" runat="server" Placeholder="username"/>
        </div>
        <div>
            <asp:Label ID="passwordLabel" runat="server" Text="Password: " Style="font-weight: bold" />
            <asp:TextBox ID="passwordLogin" runat="server" Placeholder="pasword" TextMode="Password"/>
        </div>
            <br />
        <div>
            <asp:CheckBox ID="rememberMeLogin" runat="server" Text="Remember Me" />
        </div>
        <div>
            <asp:Button ID="SubmitLogin" runat="server" Text="Login" OnClick="SubmitLogin_Click" />
        </div>
        <div>
            <asp:LinkButton ID="RegisterPageButton" runat="server" Text="No account? register here ^^" OnClick="RegisterPageButton_Click" />
        </div>
            <hr />
       <div>
            <asp:Label ID="errorLabel" runat="server" Text="" />
        </div>
            </form>
</body>
</html>
