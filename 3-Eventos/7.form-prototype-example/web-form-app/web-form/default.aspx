<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="web_form._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col">
            <%--autogenerateColumns = false, para que yo elija las columnas a mostrar--%>

                <%--el OnSelectedIndexChanged se ejecuta cuando cambia el seleccionado de la grilla, ahora lo unico disponible
                para interactuar en la grilla es el COMMANDFIELD de seleccionar, por lo que cuando se toque alguno se activa--%>

            <%--LE ASIGNO A LA GRILLA UN DATO CLAVE (dataKeyNames) PARA PODER HACER REFERENCIA DESPUES A EL Y MANIPULAR LOS DATOS:id
            es el valor de la propiedad del objeto--%>
            <asp:GridView runat="server" ID="dgvDirecciones" DataKeyNames="Id" OnSelectedIndexChanged="dgvDirecciones_SelectedIndexChanged" AutoGenerateColumns="false" CssClass="table table-bordered">
                <Columns>
                    <%--datafield = propiedad que quiero traer del objeto enlazado para mostrar en la grilla--%>
                    <asp:BoundField HeaderText="Calle" DataField="calle" />
                    <asp:BoundField HeaderText="Altura" DataField="altura"/>
                    <%--agrega un boton para interactuar con la fila (seleccionar, eliminar, etc)--%>
                    <asp:CommandField  ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion"/>
                </Columns>
            </asp:GridView>
            <a href="direccionForm.aspx" class="btn btn-primary">Agregar Direccion</a>
        </div>
    </div>
</asp:Content>
