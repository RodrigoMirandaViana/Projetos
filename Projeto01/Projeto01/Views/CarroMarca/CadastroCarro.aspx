<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCarro.aspx.cs" Inherits="Projeto01.Views.CarroMarca.CadastroCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   <h1><asp:Label ID="lbltitulo" runat="server" Text="Cadastro de Carro" BorderStyle="Groove"></asp:Label></h1> 
    <br />
    <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label><asp:TextBox ID="txtNome" runat="server" Width="185px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição:"></asp:Label><asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" /> <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
</asp:Content>
