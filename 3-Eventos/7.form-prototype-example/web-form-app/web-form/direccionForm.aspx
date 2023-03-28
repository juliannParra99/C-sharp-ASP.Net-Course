<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="direccionForm.aspx.cs" Inherits="web_form.direccionForm" %>

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
                <label for="txtCalle" class="form-label">Calle</label>
                <asp:TextBox runat="server" ID="txtCalle" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtAltura" class="form-label">Altura</label>
                <asp:TextBox runat="server" ID="txtAltura" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" />
                <a href="default.aspx" class="btn btn-primary">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
