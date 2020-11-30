<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoEdit.aspx.cs" Inherits="App.WebForm.Manteminientos.AlumnoEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="hidCodigo" runat="server" />
    <div class="form-horizontal">
        <div class="form-group">
            <label>Nombre</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Apellido</label>
            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Direccion</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Sexo</label>
            <asp:TextBox ID="txtSexo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Fecha</label>
            <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
        </div>

        <div class="form-group">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Manteminientos/Alumno.aspx">Listado de artistas</asp:HyperLink>
        </div>
    </div>
</asp:Content>
