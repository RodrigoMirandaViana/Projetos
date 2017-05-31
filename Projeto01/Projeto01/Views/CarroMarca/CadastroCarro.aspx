<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCarro.aspx.cs" Inherits="Projeto01.Views.CarroMarca.CadastroCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
   <h1><asp:Label ID="lbltitulo" runat="server" Text="Cadastro de Carro" BorderStyle="Outset"></asp:Label></h1> 
    <br />
    <asp:Label ID="lblNome" runat="server" Text="Nome:" BorderStyle="Outset"></asp:Label><asp:TextBox ID="txtNome" runat="server" Width="185px" BorderStyle="Outset"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição:" BorderStyle="Outset" Height="28px" Width="78px"></asp:Label><asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" BorderStyle="Outset" Height="37px" Width="155px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPopular" runat="server" Text="Popular" BorderStyle="Outset" style="margin-top: 0px"></asp:Label>&nbsp; SIM<asp:RadioButton ID="RadioButton1" runat="server"  />
    NÃO<asp:RadioButton ID="RadioButton2" runat="server" />
    <br />
    <br />
   
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" /> <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    <asp:Button ID="btnCadModelo" runat="server" Text="CadastrarModelo" OnClick="btnCadModelo_Click" />
</asp:Content>
