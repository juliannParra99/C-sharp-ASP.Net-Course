<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="autoForm.aspx.cs" Inherits="web_form.autoForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control" />
            </div>
            <%--en este caso esto va a ser un text area, pero en .net es un textBox pero con el textMode="multiline" prop de asp
            para que el textBox sea text area--%>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" CssClass="form-control" />
            </div>

            <%--el color va a ser un desplegable , y lo cargo con el code behind--%>
            <div class="mb-3">
                <label for="ddlColores" class="form-label">Colores</label>
                <asp:DropDownList ID="ddlColores" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>

            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha</label>
                <asp:TextBox runat="server" ID="txtFecha" TextMode="Date" CssClass="form-control" />
            </div>

            <label class="form-check-label" for="cbUsado">Usado</label>
            <asp:CheckBox ID="cbUsado" runat="server" />


            <div class="mb-3">
                <asp:RadioButton ID="rdbImportado" AutoPostBack="true" Text="Importado" runat="server" GroupName="importado" />
                <asp:RadioButton ID="rdbNacional"  AutoPostBack="true" Text="Nacional" runat="server" Checked="true" GroupName="importado" />
            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" CssClass="btn btn-primary"/>
                <a class="btn btn-primary" href="default.aspx">Cancelar</a>
            </div>


        </div>
    </div>
</asp:Content>
