<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualizar.aspx.cs" Inherits="CRUDEstatusAlumno.Vistas.Actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <dl>
        <dt>
            ID:
        </dt>
        <dd>
            <asp:TextBox ID="tbid" runat="server" Enabled="false"></asp:TextBox>
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
    <asp:Button ID="btnmodificar" runat="server" Text="Modificar" OnClick="btnmodificar_Click" />
    <a href="Index.aspx">Regresar</a>
</asp:Content>
