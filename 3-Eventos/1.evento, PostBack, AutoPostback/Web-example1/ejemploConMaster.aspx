<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="Web_example1.ejemploConMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Agrega tu nombre bro</h1>
    <asp:TextBox ID="txtNombre"   runat="server" AutoPostBack="true" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
    <asp:Button ID="btnAgregar" Text="aceptar" runat="server" OnClick="btnAgregar_Click" />
    <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>

    <br />

    <asp:Label Text="" ID="lblSecundario" runat="server" />

    <br />
    

    <a href="about">Go to about</a>
</asp:Content>

