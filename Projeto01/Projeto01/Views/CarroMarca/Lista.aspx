<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Projeto01.Views.CarroMarca.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1>Marcas Cadastradas</h1>
    <asp:GridView ID="gdvCarros" runat="server" BorderStyle="Outset" Width="282px"></asp:GridView>
    <asp:Button ID="btnEditarcar" runat="server" Text="Editar" OnClick="btnEditarcar_Click" /><asp:Button ID="btnExcluircar" runat="server" Text="Excluir" OnClick="btnExcluircar_Click1"/>

    <br />

    <br />
    <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label><asp:TextBox ID="txtId" runat="server" Width="72px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;<br />
    <br />
    &nbsp;<asp:Label ID="lblEditar" runat="server" Text="EDITAR" BorderColor="White" ForeColor="#00CC66" BorderStyle="Outset"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblNomeEditar" runat="server" Text="Nome" BorderStyle="Outset"></asp:Label>
    <asp:TextBox ID="txtNomeEditar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblDescricaoEditar" runat="server" Text="Descrição" BorderStyle="Outset" Height="30px" Width="87px"></asp:Label>
    <asp:TextBox ID="txtDescricaoEditar" runat="server" Height="41px" TextMode="MultiLine"></asp:TextBox>
    <br />
    <h1>Modelos Cadastrados</h1>
    <asp:GridView ID="gdvModelos" runat="server" BorderStyle="Outset" Width="283px"></asp:GridView>
     <asp:Button ID="btnEditarmod" runat="server" Text="Editar" OnClick="btnEditarmod_Click" /><asp:Button ID="btnExcluirmod" runat="server" Text="Excluir" OnClick="btnExcluirmod_Click" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label><asp:TextBox ID="txtNome" runat="server" Height="20px" Width="117px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblEditar0" runat="server" Text="EDITAR" BorderColor="White" ForeColor="#00CC66" BorderStyle="Outset"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblNomeEditar1" runat="server" Text="Nome" BorderStyle="Outset"></asp:Label>
    <asp:TextBox ID="txtNomeEditar1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblAno" runat="server" Text="Ano" BorderStyle="Outset"></asp:Label>
    &nbsp;<asp:ListBox ID="listAno" runat="server" Height="40px" BackColor="Black" Width="71px">
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
</asp:Content>
