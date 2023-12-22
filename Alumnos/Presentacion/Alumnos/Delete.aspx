<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentacion.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2> Eliminar Alumno </h2>
    <h4> Desea eliminar al Alumno? </h4>
    <div>
            <!-- Par de label html - Control asp por cada propiedad -->
            <div>
                <!-- Control asp para mostrar/Introducir valor de la propiedad -->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label1" runat="server" Text="ID:" CssClass="label label-default form-control"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbid" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="label label-default "></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbnombre" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label3" runat="server" Text="Primer Apellido:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbprimerApellido" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label4" runat="server" Text="Segundo Apellido:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbsegundoApellido" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label5" runat="server" Text="Correo:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbcorreo" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label6" runat="server" Text="Telefono:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbtelefono" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label7" runat="server" Text="Fecha de Nacimiento:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbfechaNacimiento" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label8" runat="server" Text="Telefono:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbcurp" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label9" runat="server" Text="Sueldo Mensual:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbsueldo" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label10" runat="server" Text="Estado:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbidestado" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
                <!---->
                <div class="row">
                    <div class="col-xs-2 text-right">
                        <h4>
                            <asp:Label ID="Label11" runat="server" Text="Estatus:" CssClass="label label-default"></asp:Label>
                        </h4>

                    </div>
                    <div class="col-xs-3">
                        <asp:Label ID="lbidestatus" runat="server" Text="" CssClass="form-control"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

    <div>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger"/>
    </div>

    <div>
        <a href="Index.aspx">Regresar</a>
    </div>

</asp:Content>
