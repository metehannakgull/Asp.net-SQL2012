<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateAbility.aspx.cs" Inherits="MyCv4.UpdateAbility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Update Ability Page</h2>
    <br />
   <asp:TextBox ID="TextBox1" runat="server"  CssClass="form-control" placeholder="Enter ability.."></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save"  CssClass="btn btn-group" OnClick="Button1_Click"/>

</asp:Content>
