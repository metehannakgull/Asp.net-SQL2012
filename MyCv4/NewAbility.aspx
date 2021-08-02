<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NewAbility.aspx.cs" Inherits="MyCv4.NewAbility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Add New Ability Page</h2>
    <br />
  <!--  <asp:Label ID="Label1" runat="server" Text="Enter Ability"></asp:Label>-->
    <asp:TextBox ID="TextBox1" runat="server"  CssClass="form-control" placeholder="Enter ability.."></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button"  CssClass="btn btn-info" OnClick="Button1_Click"/>
</asp:Content>
