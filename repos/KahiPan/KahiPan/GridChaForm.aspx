<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridChaForm.aspx.cs" Inherits="KahiPan.GridChaForm" %>


<form id="Form1" runat="server">
    <asp:label runat="server" text="Select Country"></asp:label>
    <asp:dropdownlist id="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        
    </asp:dropdownlist>
    <br />
    <br />

    <asp:gridview id="GridView1" runat="server" OnSelectedIndexChanged="Unnamed3_SelectedIndexChanged"></asp:gridview>
</form>
    
