<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Setup.aspx.cs" Inherits="Setup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="titleContentPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPlaceHolder" Runat="Server">
    <asp:Button ID="darkButton" runat="server" Text="Dark" OnClick="darkButton_Click" />
    <asp:Button ID="lightButton" runat="server" Text="Light" OnClick="lightButton_Click" />
</asp:Content>

