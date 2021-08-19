<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="My_CART.Home" MasterPageFile="~/Cart.Master"  %>

<asp:Content ContentPlaceHolderID ="ContentPlaceHolder1" runat="server">
<asp:DataList ID="DataList1" runat="server">
<ItemTemplate>
    <table>
        <tr>
            <td><%#Eval("@user") %></td>
        </tr>
    </table>
</ItemTemplate>
</asp:DataList>

</asp:Content>