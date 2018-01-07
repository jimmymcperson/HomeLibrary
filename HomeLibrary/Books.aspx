<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<asp:Content ID="mainID" ContentPlaceHolderID="mainContentPlaceHolder" Runat="Server">
    <h1>Books</h1>
  <p>This is the books page<asp:GridView ID="BookGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ISBN" DataSourceID="SqlDataSource1">
      <Columns>
          <%--<asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />--%>
          <asp:TemplateField HeaderText="Title">
              <ItemTemplate>
                  <asp:LinkButton ID="bookLink" runat="server" Text='<%#Eval("Title") %>' OnClick="bookLink_Click">
                  </asp:LinkButton>
              </ItemTemplate>
          </asp:TemplateField>
          <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
          <asp:BoundField DataField="ISBN" HeaderText="ISBN" ReadOnly="True" SortExpression="ISBN" />
      </Columns>
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" ProviderName="<%$ ConnectionStrings:Database1ConnectionString.ProviderName %>" SelectCommand="SELECT [ISBN], [Title], [Author] FROM [Book]"></asp:SqlDataSource>
      <asp:Button ID="RemoveAllButton" runat="server" OnClick="removeAllButton_Click" Text="Remove All" />
    </p>

    </asp:Content>
<asp:Content ID="titleID" ContentPlaceHolderID="titleContentPlaceHolder" Runat="Server">
    Home
</asp:Content>

