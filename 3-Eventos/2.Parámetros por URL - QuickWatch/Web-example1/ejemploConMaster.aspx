<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="Web_example1.ejemploConMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Agrega tu nombre bro</h1>
    <asp:TextBox ID="txtNombre"   runat="server"  OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
    <asp:Button ID="btnAgregar" Text="aceptar" runat="server" OnClick="btnAgregar_Click" />
    <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>

    <br />

    <asp:Label Text="" ID="lblSecundario" runat="server" />

    <br />
    
    <!--otra forma de utilizar el pasaje de variables por url. en este caso, le asigno a esa ruta una variables desde
        el principio. Esa ruta puede ser dinamica etc-->
    <a href="Default?id=3">Go to home</a>
</asp:Content>

