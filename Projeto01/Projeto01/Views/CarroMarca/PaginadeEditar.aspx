<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginadeEditar.aspx.cs" Inherits="Projeto01.Views.CarroMarca.Pagina_de_Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   <h1><asp:Label ID="lbltitulo" runat="server" Text="Editar Marca" BorderStyle="Outset"></asp:Label></h1> 
    <br />
    <asp:Label ID="lblNome" runat="server" Text="Nome:" BorderStyle="Outset"></asp:Label><asp:TextBox ID="txtNome" runat="server" Width="185px" BorderStyle="Outset"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição:" BorderStyle="Outset" Height="28px" Width="78px"></asp:Label><asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" BorderStyle="Outset" Height="37px" Width="155px"></asp:TextBox>
    <br />
    <br />
   
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" /> <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    <br />
    <br />
    <asp:GridView ID="gdvCarros" runat="server" BorderStyle="Outset" Width="282px">
    </asp:GridView>
</asp:Content>
