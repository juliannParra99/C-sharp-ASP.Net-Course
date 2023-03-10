<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="Web_example1.ejemploConMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Agrega tu nombre bro</h1>
    <asp:TextBox ID="txtNombre"   runat="server"></asp:TextBox>
    <asp:Button ID="btnAgregar" Text="aceptar" runat="server" OnClick="btnAgregar_Click" />
    <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>



    <h2> haz click para ver los checkbox random</h2>
    <asp:Button ID="btnCheckBox" runat="server" Text="Mostrar" OnClick="btnCheckBox_Click1" />
    <asp:CheckBox ID="cbRandom" Visible="false" Text="pato" runat="server" />
</asp:Content>

