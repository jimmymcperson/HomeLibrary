<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Addbook.aspx.cs" Inherits="Addbook" %>
<%@ Register TagPrefix="wut" TagName="WebUserCTR" Src="WebUserControl.ascx"%>

<asp:Content ID="mainID" ContentPlaceHolderID="mainContentPlaceHolder" Runat="Server">
    <h1>Add Book</h1>
  <p>
      <asp:Label ID="nameLabel" runat="server" Text="Name of book: "></asp:Label>
      <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required Field" ControlToValidate="nameTextBox" Display="None"></asp:RequiredFieldValidator>
      <br>
      <asp:Label ID="authorLabel" runat="server" Text="Author(s): "></asp:Label>
      <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="authorRequiredFieldValidator" runat="server" ErrorMessage="Required Field" ControlToValidate="authorTextBox" Display="None"></asp:RequiredFieldValidator>
      <br>
      <asp:Label ID="isbnLabel" runat="server" Text="ISBN Number: "></asp:Label>
      <asp:TextBox ID="isbnTextBox" runat="server"></asp:TextBox>
      <br>
      <asp:Label ID="genreLabel" runat="server" Text="Genre: "></asp:Label>
      <asp:DropDownList ID="genreDropDownList" runat="server">
          <asp:ListItem>Non Fiction</asp:ListItem>
          <asp:ListItem>Mystery</asp:ListItem>
          <asp:ListItem>Sci Fi</asp:ListItem>
          <asp:ListItem>Romance</asp:ListItem>
          <asp:ListItem>Horror</asp:ListItem>
      </asp:DropDownList>

      <br>
      <asp:Label ID="pagesLabel" runat="server" Text="Number of Pages: "></asp:Label>
      <asp:TextBox ID="pagesTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="pagesRequiredFieldValidator" runat="server" ErrorMessage="Required Field" ControlToValidate="pagesTextBox" Display="None"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="pagesRangeValidator" runat="server" ErrorMessage="Needs to be a positive integer below 10000" ControlToValidate="pagesTextBox" Display="None" MaximumValue="10000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
      <br>
      <asp:CheckBox ID="lendedCheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="lendedCheckBox_CheckedChanged" /> Lended? 
      <br>
      <asp:Label ID="friendNameLabel" runat="server" Text="Name of Friend: " Visible="False"></asp:Label>
      <asp:TextBox ID="friendNameTextBox" runat="server" Visible="False" Enabled="False"></asp:TextBox>
        <asp:RequiredFieldValidator ID="friendNameRequiredFieldValidator" runat="server" ErrorMessage="Required Field" Enabled="False" Display="None" ControlToValidate="friendNameTextBox"></asp:RequiredFieldValidator>
      <br>
      <asp:Label ID="commentsLabel" runat="server" Text="Comments: "></asp:Label>
      <asp:TextBox ID="commentsTextBox" runat="server" Rows="5"></asp:TextBox>
      <br>
      <br>
      <input type="reset" value="Cancel (Clear All)" />
      <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
      <p>
          <br>
          <br>
      <wut:webuserCTR ID="test" runat="server" />
  </asp:Content>
<asp:Content ID="titleID" ContentPlaceHolderID="titleContentPlaceHolder" Runat="Server">
    Add Book
</asp:Content>

