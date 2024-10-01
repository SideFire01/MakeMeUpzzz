<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="MakeMeUpzz.Views.ManageMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Makeup Management Page</h1>
        <hr />

        <h3>Product Database</h3>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:BoundField DataField="MakeupID" HeaderText="Id" SortExpression="MakeupID"  />
                    <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                    <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                    <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight" />

                    <asp:BoundField DataField="MakeupType.MakeupTypeID" HeaderText="Type" SortExpression="MakeupTypeID" />
                    <asp:BoundField DataField="MakeupBrand.MakeupBrandID" HeaderText="Brand ID" SortExpression="MakeupBrandID" />

                    <asp:TemplateField HeaderText="Options">
                        <ItemTemplate>
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Update" />
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div>
                <br />
    <asp:Button ID="InsertMakeup" runat="server" Text="Add New Makeup" onclick="InsertMakeup_Click"/>
</div>
        </div>
        <br />
        <hr />
        <h3>Types Database</h3>
        <div>
            <asp:GridView ID="Type" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" OnRowDeleting="Type_RowDeleting" OnRowEditing="UpdateType">
                <Columns>
                    <asp:BoundField DataField="MakeupTypeID" HeaderText="Id" SortExpression="MakeupTypeID" />
                    <asp:BoundField DataField="MakeupTypeName" HeaderText="Name" SortExpression="MakeupTypeName" />
                    <asp:TemplateField HeaderText="Options">
                        <ItemTemplate>
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Update" />
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
             <div>
                     <asp:Button ID="InsertMakeupType" runat="server" Text="Add New Type" onclick="InsertMakeupType_Click"/>
            </div>
        </div>
        <br />
        <hr />
        <h3>Brands Database</h3>
        <div>
            <asp:GridView ID="Brand" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" OnRowDeleting="Brand_RowDeleting" OnRowEditing="UpdateBrand">
                <Columns>
                    <asp:BoundField DataField="MakeupBrandID" HeaderText="Id" SortExpression="MakeupBrandID" />
                    <asp:BoundField DataField="MakeupBrandName" HeaderText="Name" SortExpression="MakeupBrandName" />
                    <asp:TemplateField HeaderText="Options">
                        <ItemTemplate>
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Update" />
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
             <div>
                     <asp:Button ID="InsertMakeupBrand" runat="server" Text="Add New  Brand" onclick="InsertMakeupBrand_Click"/>
            </div>
        </div>
        <br />
        <hr />
    </form>
</body>
</html>
