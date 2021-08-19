<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="My_CART.Register" MasterPageFile="~/Cart.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
  <div class="Parent-Contanier">
   <div class="Modal">
    <div class="Modal-content">
    <h2> Register</h2><br />   
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
   
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem>Male</asp:ListItem>
    <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
  
    <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click" />
   </div>
 </div>
 </div>
</asp:Content>

