<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MakeMeUpzz.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <form id="form1" runat="server">
     <h1>Registration Page</h1>
     <hr />
     <h3>Select your birth date ^^</h3>
      <div>
     <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
     </div>
     <br />
     <h3>Enter other credentials here</h3>
     <div>
         <asp:Label ID="usernameLabel" runat="server" Text="Username: " Style="font-weight: bold"/>
         <asp:TextBox ID="usernameRegister" runat="server" Placeholder="username here"/>
     </div>
      <div>
         <asp:Label ID="emailLabel" runat="server" Text="Email: " Style="font-weight: bold"/>
         <asp:TextBox ID="emailRegister" runat="server" Placeholder="email@gmail.com"/>
     </div>
     <div>
         <asp:RadioButton ID="male" runat="server" Text="Male" GroupName="gender"/>
         <asp:RadioButton ID="female" runat="server" Text="Female" GroupName="gender"/>
     </div>
     <div>
         <asp:Label ID="passwordLabel" runat="server" Text="Password: " Style="font-weight: bold"/>
         <asp:TextBox ID="passwordRegister" runat="server" Placeholder="password here" TextMode="Password" />
     </div>
     <div>
         <asp:Label ID="confirmPasswordLabel" runat="server" Text="Confirm Password: " Style="font-weight: bold" />
         <asp:TextBox ID="confirmPasswordRegister" runat="server" Placeholder="repeat password here" TextMode="Password" />
     </div>
        <br />
     <div>
         <asp:Button ID="SubmitRegister" runat="server" Text="Confirn" OnClick="SubmitRegister_Click" />
     </div>

     <div>
         <asp:LinkButton ID="LoginPageButton" runat="server" Text="Login here if you already have an account ^^" OnClick="LoginPageButton_Click" />
     </div>
     <div>
         <asp:Label ID="registerError" runat="server" Text=""></asp:Label>
     </div>
 </form>
</body>
</html>
