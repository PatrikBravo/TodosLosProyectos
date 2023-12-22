<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Alumnos.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <asp:Button ID="btnVistaAgregar" runat="server" Text="Agregar" CssClass="btn btn-info" OnClick="btnVistaAgregar_Click"/>
    </div>
    <br />
    <asp:GridView ID="gvAlumnos" runat="server" Height="223px" AllowPaging="True" AutoGenerateColumns="False" CssClass="table table-dark table-striped" OnPageIndexChanging="gvAlumnos_PageIndexChanging" OnRowCommand="gvAlumnos_RowCommand">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="primerApellido" HeaderText="Primer_Apellido" />
            <asp:BoundField DataField="segundoApellido" HeaderText="Segundo_Apellido" />
            <asp:BoundField DataField="correo" HeaderText="Correo" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="idEstadoOrigen" HeaderText="Estado" />
            <asp:BoundField DataField="idEstatus" HeaderText="Estatus" />
            <asp:ButtonField CommandName="btndetalle" Text="Detalles">
                <ControlStyle CssClass="btn btn-warning btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btneditar" Text="Editar">
                <ControlStyle CssClass="btn btn-success btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btneliminar" Text="Eliminar">
                <ControlStyle CssClass="btn btn-danger btn-sm" />
            </asp:ButtonField>
        </Columns>
    </asp:GridView>
</asp:Content>
