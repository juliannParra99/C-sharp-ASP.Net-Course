<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="web_form._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col">
            <asp:GridView runat="server" ID="dgvAuto" CssClass="table table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Modeloo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Color" DataField="Color" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
                </Columns>
                

            </asp:GridView>
            <a href="autoForm.aspx">Agregar</a>
        </div>
    </div>
</asp:Content>
