<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MyCv4.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered" style="margin-left:30px; margin-right:30px">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Mail</th>
            <th>Message</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                    <tr>
                        <td><%#  Eval("Id") %></td>
                        <td><%# Eval("Adsoyad") %></td>
                        <td><%# Eval("Mail")  %></td>
                        
                        <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%# "MessageDetail.aspx?Id="+ Eval("Id") %>'>see message</asp:HyperLink></td>
                    </tr>
            </ItemTemplate>
        </asp:Repeater>
        
    </table>
</asp:Content>
