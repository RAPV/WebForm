<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="App.WebForm.Manteminientos.Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    </br>
    <div class="form-inline">
        <div class="form-group">
            <asp:TextBox ID="txtFilterByName" runat="server"
                CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar"
            CssClass="btn btn-primary" OnClick="btnBuscar_Click"
            />
    </div>
    <div >
        <div class="form-group">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Manteminientos/AlumnoEdit.aspx">Nuevo Alumno</asp:HyperLink>
        </div>
    </div>
    <div class="container">
        <asp:GridView ID="dgvListado" runat="server" CssClass="table table-striped" GridLines="None" HeaderStyle-CssClass="thead-dark" AutoGenerateColumns="false">
            <Columns>
                <asp:HyperLinkField 
                    HeaderText="Código" 
                    DataTextField="AlumnoID" 
                    DataNavigateUrlFormatString="~/Mantenimientos/EditArtist.aspx?cod={0}"
                    DataNavigateUrlFields="AlumnoID"/>
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" />
                <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" />
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
                <asp:BoundField HeaderText="FechaNacimiento" DataField="FechaNacimiento" />
                 <asp:HyperLinkField 
                    HeaderText="" 
                    DataTextField="" 
                    DataNavigateUrlFormatString="~/Manteminientos/AlumnoEdit.aspx?cod={0}"
                    DataNavigateUrlFields="AlumnoID"
                    Text="Editar"
                    ControlStyle-CssClass="btn btn-warning"/>
                <asp:HyperLinkField 
                    HeaderText="" 
                    DataTextField="" 
                    DataNavigateUrlFormatString="~/Manteminientos/AlumnoEdit.aspx?cod={0}"
                    DataNavigateUrlFields="AlumnoID"
                    Text="Eliminar"
                    ControlStyle-CssClass="btn btn-danger"/>
            </Columns>
        </asp:GridView>
        
    </div>

</asp:Content>
