<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="CRUDEstatusAlumno.Vistas.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <dl>
        <dt>
            ID:
        </dt>
        <dd>
            <asp:TextBox ID="tbid" runat="server"></asp:TextBox>
        </dd>

        <dt>
            Clave:
        </dt>
        <dd>
            <asp:TextBox ID="tbclave" runat="server"></asp:TextBox>
        </dd>

        <dt>
            Nombre:
        </dt>
        <dd>
            <asp:TextBox ID="tbnombre" runat="server"></asp:TextBox>
        </dd>
    </dl>
    <asp:Button ID="btngregar" runat="server" Text="Agregar" OnClick="btngregar_Click" />
    <a href="Index.aspx">Regresar</a>
</asp:Content>
