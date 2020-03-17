<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NewWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            I live in : <%Response.Write(GetCity()); %>
            <br />
            I stay in : <% string b = GetCity();Response.Write(b); %>
            <br />
            I live :<%:GetCity() %>
            <br />
            <asp:Repeater ItemType="System.String" SelectMethod="GetCities" runat="server">
                <ItemTemplate><li>
                    <%# Item %></li>

                </ItemTemplate>

            </asp:Repeater>
        </div>
    </form>
</body>
</html>
