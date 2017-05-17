<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aula_17._05.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate>

             <asp:Label ID="lblQuantidadeCliques" runat="server" BorderStyle="Dashed"></asp:Label>
                <br />
             <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" BackColor="Black" BorderStyle="Inset" ForeColor="White" />
                <br />
             <asp:Button ID="btnEnviarCliques" runat="server" Text="Enviar" OnClick="btnEnviarCliques_Click" />
       </ContentTemplate>
     </asp:UpdatePanel>
</asp:Content>
