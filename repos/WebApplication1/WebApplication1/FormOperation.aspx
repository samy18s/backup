<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormOperation.aspx.cs" Inherits="WebApplication1.FormOperation" %>


<asp:Content ID="in123" ContentPlaceHolderID="MainContent" runat="server">

<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<br />
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
<br />
    <asp:Button ID="Button1" Width="89px" runat="server" Text="Insert" OnClick="Button1_Click" />
    <asp:Button ID="Button2" Width="89px" runat="server" Text="Update" OnClick="Button2_Click" />
    <asp:Button ID="Button3" Width="89px" runat="server" Text="Delete" OnClick="Button3_Click" />
    <asp:Button ID="Button4" Width="89px" padding="10px" runat="server" Text="Search" OnClick="Button4_Click" />
    <br />
    <br />
    <br />

    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    </asp:Content>
