<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="web_form._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%--esta es la manera manual de acceder al id y ocultar la columna pero voy a usar el metodo .net
        que es indcandole al control de la grilla el data key, que es la propiedad id del objeto
        <style>
        .oculto{
            display: none;
        }
    </style>--%>
    <div class="row">
        <div class="col">
            <%--le agrego el evento al gridView: OnSelectedIndexChanged}: ocurre cuando tocas algo en el boton de seleccion--%>
            <%--EL DATA KEY ES EL ID: Al momento de capturar una seleccion, voy a capturar el selectedDataKey, en el code
                behind--%>
            <asp:GridView runat="server" ID="dgvAuto" DataKeyNames="Id" OnSelectedIndexChanged="dgvAuto_SelectedIndexChanged" CssClass="table table-bordered" AutoGenerateColumns="false">
                <columns>
                    <%--aca lo que hago dejar visible la columna id, pero oculto el header y el itemStyle, por que el control
                    asp cuando pasa a html se convierte en varios elementos, y con esto oculto todos--%>
                    <%--<asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>--%>
                    <asp:BoundField HeaderText="Modeloo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
                    <%--esto muestra una accion de seleccion; SelectText="Seleccionar" es el nombre del boton--%>
                    <asp:CommandField  ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion"/>
                </columns>


            </asp:GridView>
            <a href="autoForm.aspx">Agregar</a>
        </div>
    </div>
</asp:Content>
