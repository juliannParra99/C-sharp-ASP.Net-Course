<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_example1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <!--aca se genera un if para ejecutar un codigo o el otro OJO CON LA SINTAXIS DEL TEMPLATE ENGINE; el codigo
        C# va dentro de los piquitos el codigo html no; dibuja el uno o el otro dependiendo lo que halla-->

    <!--si user es disinto de vacio, quiere decir que hay un usuario, por lo que el usuario s elogeo, sino necesita logearse-->
    <%if (user != "")
        { %> 
    
        <h2>Ingresaste</h2>
        <asp:Label Text="text" ID="lblUser" runat="server" />

    <%}
    else
    { %>
        <h2>Debes logearte</h2>
        <a href="ejemploConMaster">Login</a>
    <br />
    <%} %>


</asp:Content>
