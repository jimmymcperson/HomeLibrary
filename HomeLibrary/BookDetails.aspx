<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BookDetails.aspx.cs" Inherits="BookDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleContentPlaceHolder" Runat="Server">
    Book Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" Runat="Server">
    <asp:DetailsView ID="BookDetailsView" runat="server" Height="50px" Width="125px" OnItemUpdated="BookDetailsView_ItemUpdated" OnItemUpdating="BookDetailsView_ItemUpdating" OnModeChanging="BookDetailsView_ModeChanging">
        <Fields>
            <asp:CommandField ShowEditButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:Button ID="DeleteBookButton" runat="server" OnClick="DeleteBookButton_Click" Text="Delete Book" />
</asp:Content>
