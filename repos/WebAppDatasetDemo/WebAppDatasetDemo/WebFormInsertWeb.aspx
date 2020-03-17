<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebFormInsertWeb.aspx.cs" Inherits="WebAppDatasetDemo.WebFormInsertWeb" %>

<asp:Content ID="in123" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
</asp:Content>