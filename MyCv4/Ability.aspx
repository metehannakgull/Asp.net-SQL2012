<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ability.aspx.cs" Inherits="MyCv4.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="table table-bordered" style="margin-left:30px; margin-right:30px">
        <tr>
            <th>Id</th>
            <th>Ability</th>
            <th>Derece</th>
            <th>Delete</th>
            <th>Update</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                    <tr>
                        <td><%#  Eval("Id") %></td>
                        <td><%# Eval("Yetenek") %></td>
                        <td><%# Eval("Derece")  %></td>
                        <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%# "DeleteAbility.aspx?Id="+ Eval("Id") %>'>delete</asp:HyperLink></td> <!--Silme sayfasına yönlendirme. Sileceğimiz veri DeleteAbility sayfasına yönlenir. -->
                        
                        <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl='<%# "UpdateAbility.aspx?Id="+ Eval("Id") %>'>update</asp:HyperLink></td>
                    </tr>
            </ItemTemplate>
        </asp:Repeater>
        
    </table>
    <a href="NewAbility.aspx" class="btn btn-success" style="margin-left:30px">Add new ability </a>
</asp:Content>
