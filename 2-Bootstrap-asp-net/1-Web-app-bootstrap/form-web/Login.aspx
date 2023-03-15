<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="form_web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email address</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
            </div>
            <div class="mb-3">
                <label for="txtPassword" class="form-label">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" type="password" />
            </div>
            <asp:Button Text="Submit" CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" />

        </div>
    </div>
    <div class="row user-data">
        <div class="col-2"></div>
        <div class="col">
            <asp:Label Text="" ID="lblUserEmail" CssClass="form-label" runat="server" />
            <asp:Label Text="" ID="lblUserPassword" CssClass="form-label" runat="server" />
        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>
