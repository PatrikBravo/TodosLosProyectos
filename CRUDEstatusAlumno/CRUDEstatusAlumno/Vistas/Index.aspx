<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CRUDEstatusAlumno.Vistas.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <asp:DropDownList ID="ListaEstatus" runat="server"></asp:DropDownList>
    </div>
    <br />
    <div>
        <asp:Button ID="Agregar" runat="server" Text="Agregar" OnClick="Agregar_Click" />
        <asp:Button ID="Detalles" runat="server" Text="Detalles" OnClick="Detalles_Click" />
        <asp:Button ID="Editar" runat="server" Text="Editar" OnClick="Editar_Click" />
        <asp:Button ID="Elimar" runat="server" Text="Elimar" OnClick="Elimar_Click" />
    </div>
    <br />
</asp:Content>
