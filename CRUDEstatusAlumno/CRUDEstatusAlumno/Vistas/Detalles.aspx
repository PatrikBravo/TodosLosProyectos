<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="CRUDEstatusAlumno.Vistas.Detalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dl>
        <dt>
            ID:
        </dt>
        <dd>
            <asp:Label ID="lbid" runat="server" Text=""></asp:Label>
        </dd>

        <dt>
            Clave:
        </dt>
        <dd>
            <asp:Label ID="lbclave" runat="server" Text=""></asp:Label>
        </dd>

        <dt>
            Nombre:
        </dt>
        <dd>
            <asp:Label ID="lbnombre" runat="server" Text=""></asp:Label>
        </dd>
    </dl>

    <a href="Index.aspx">Regresar</a>
</asp:Content>
