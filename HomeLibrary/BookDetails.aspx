<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDetails.aspx.cs" Inherits="BookDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleContentPlaceHolder" Runat="Server">
    Book Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" Runat="Server">
    <asp:GridView ID="BookDetailsGridView" runat="server">
</asp:GridView>
    <asp:Button ID="DeleteBookButton" runat="server" OnClick="DeleteBookButton_Click" Text="Delete Book" />
</asp:Content>
