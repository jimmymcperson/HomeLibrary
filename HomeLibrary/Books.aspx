<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<asp:Content ID="mainID" ContentPlaceHolderID="mainContentPlaceHolder" Runat="Server">
    <h1>Books</h1>
  <p>This is the books page</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ISBN" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:TemplateField HeaderText="Title" >
            <ItemTemplate>
            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="<%# Bind('Title') %>" CommandArgument="<%# Bind('ManufactureID') %>"></asp:LinkButton>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" ReadOnly="True" SortExpression="ISBN" />
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" ProviderName="<%$ ConnectionStrings:Database1ConnectionString.ProviderName %>" SelectCommand="SELECT [ISBN], [Title], [Author] FROM [Book]"></asp:SqlDataSource>
    <div id=""
    <asp:Button ID="removeAllButton" runat="server" Text="Remove All" OnClick="removeAllButton_Click" />
    </asp:Content>
<asp:Content ID="titleID" ContentPlaceHolderID="titleContentPlaceHolder" Runat="Server">
    Home
</asp:Content>

