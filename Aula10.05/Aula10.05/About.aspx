<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula10._05.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>É O BIXO</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.<asp:Calendar ID="calendar" runat="server"></asp:Calendar>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;<asp:Button ID="btn_salvar" runat="server" Height="24px" OnClick="btn_salvar_Click" Text="Salvar" Width="72px" CssClass="body-content" />
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:TextBox ID="txt_data" runat="server"></asp:TextBox>
    </p>
</asp:Content>
