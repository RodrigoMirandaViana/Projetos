<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Projeto01.Views.CarroMarca.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1>Marcas Cadastradas</h1>
    <asp:GridView ID="gdvCarros" runat="server" BorderStyle="Outset" Width="282px"></asp:GridView>
    <asp:Button ID="btnEditarcar" runat="server" Text="Editar" /><asp:Button ID="btnExcluircar" runat="server" Text="Excluir" OnClick="btnExcluircar_Click1"/>

    <br />

    <br />
    <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label><asp:TextBox ID="txtId" runat="server" Width="72px"></asp:TextBox>
    <br />
    <h1>Modelos Cadastrados</h1>
    <asp:GridView ID="gdvModelos" runat="server" BorderStyle="Outset" Width="283px"></asp:GridView>
     <asp:Button ID="btnEditarmod" runat="server" Text="Editar" OnClick="btnEditarmod_Click" /><asp:Button ID="btnExcluirmod" runat="server" Text="Excluir" OnClick="btnExcluirmod_Click" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label><asp:TextBox ID="txtNome" runat="server" Height="20px" Width="117px"></asp:TextBox>
    <br />
    <br />
</asp:Content>
