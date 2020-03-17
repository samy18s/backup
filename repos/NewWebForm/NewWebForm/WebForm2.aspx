<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="NewWebForm.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label Text="By by" runat="server"></asp:Label><br />
    <%--<span id="a1" runat="server">75</span>
    <span id="a2" runat="server">77</span>--%>

    Number1: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    Number2:  <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox><br />
    <%--Sum:  <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox><br />--%>
   <span id="spanid" runat="server"></span>
    <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />


</asp:Content>
