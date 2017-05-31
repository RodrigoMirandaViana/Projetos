<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroModelo.aspx.cs" Inherits="Projeto01.Views.CarroMarca.CadastroModelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><asp:Label ID="lblTitulo" runat="server" Text="Cadastro de Modelo"></asp:Label></h1>
    <br />
    <asp:Label ID="lblNomeModelo" runat="server" Text="Nome" BorderStyle="Outset"></asp:Label>
    <asp:TextBox ID="txtNomeModelo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblAno" runat="server" Text="Ano" BorderStyle="Outset"></asp:Label>
    <asp:ListBox ID="listAno" runat="server" Height="40px" BackColor="Black" Width="71px">
        <asp:ListItem>2017</asp:ListItem>
        <asp:ListItem>2016</asp:ListItem>
        <asp:ListItem>2015</asp:ListItem>
        <asp:ListItem>2014</asp:ListItem>
        <asp:ListItem>2013</asp:ListItem>
        <asp:ListItem>2012</asp:ListItem>
        <asp:ListItem>2011</asp:ListItem>
        <asp:ListItem>2010</asp:ListItem>
    </asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

</asp:Content>
