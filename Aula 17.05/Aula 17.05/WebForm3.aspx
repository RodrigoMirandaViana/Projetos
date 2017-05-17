<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Aula_17._05.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:TextBox ID="txtValor1" runat="server" ></asp:TextBox> 
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
            <asp:Button ID="btnSoma" runat="server" Text="+" OnClick="btnSoma_Click" />
            <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
            <br />
            <asp:Label ID="lblresult" runat="server" Text="A soma é: "></asp:Label>
            <br />
            <asp:TextBox ID="txtresult" runat="server"></asp:TextBox>
            </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
