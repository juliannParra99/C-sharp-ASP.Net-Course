<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="web_form.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--usando el id lo manipulo en el back
        tip: para agregar las clases css de bootstrap es mas facil y rapido agregarlas desde la web utilizando la seccion 
        clases de la developer tools

        si se quiere que no s emuestren todas las columnas por defecto, y podamos seleccionar las columnas a mostrar pdoemos
        usar el autoGenerateColumn = false, y despues seleccionar las columnas a mostrar utilizando dentro de la etiqueta dgv
        la etiqueta columns y configurarle el headerText, es decir el nombre de la columna que quiero mostrar
        y que yo puedo editar a guto, y el DATO que
        quiero mostrar, para eso uso el dataField que va a mostrar el dato correspondiente, y TIENE QUE CONTENER EL NOMBRE
        DE LA PROPIEDAD DEL OBJETO QUE TIENE ENLAZADO, EN ESTE CASO DE AUTO
        -->

    <asp:GridView runat="server" ID="dgvAuto" CssClass="table table-bordered" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Modeloo" DataField= "Modelo" />
            <asp:BoundField HeaderText="Color" DataField="Color" />
            <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
            <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
        </Columns>

    </asp:GridView>
</asp:Content>
