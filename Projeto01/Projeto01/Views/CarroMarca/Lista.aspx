<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Projeto01.Views.CarroMarca.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h1>Marcas Cadastradas</h1>
    <asp:GridView ID="gdvCarros" runat="server" BorderStyle="Outset"></asp:GridView>
    <br />
    <br />
    <h1>Modelos Cadastrados</h1>
    <asp:GridView ID="gdvModelos" runat="server" BorderStyle="Outset"></asp:GridView>
    <br />
    <br />
</asp:Content>
