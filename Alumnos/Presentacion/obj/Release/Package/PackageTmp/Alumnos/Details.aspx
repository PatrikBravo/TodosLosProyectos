<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>Detalles del Alumno</h2>
        <!-- Control asp Label para mensajes -->
        <hr />
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

        <div class="row">
            <div class="col-sm-6 text-center">
                <asp:Button ID="btnimss" runat="server" Text="IMSS"  CssClass="btn btn-primary" OnClick="btnimss_Click"/>
                <!-- Ventana Modal -->
                <div class="modal" id="myModalIMSS">
                    <div class="modal-dialog">
                        <div class="modal-content">

                            <!-- Encabezado Modal -->
                            <div class="modal-header">
                                <h4 class="modal-title">Calculo del IMSS</h4>
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                            </div>

                            <!-- Curepo de la Modal -->
                            <div class="modal-body">
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label12" runat="server" Text="Enfermedad y Maternidad:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbenfermedad" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label13" runat="server" Text="Invalides y Vida:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbinvalides" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            

                            
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label14" runat="server" Text="Retiro:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbretiro" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            

                           
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label15" runat="server" Text="Cesantia:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbcesantia" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            

                           
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label16" runat="server" Text="Infonavit:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbinfonavit" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            </div>

                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                            </div>

                        </div>
                    </div>
                </div>


                <input id="btnisr" type="button" value="ISR" data-toggle="modal" onclick="ajaxISR()" data-target="#myModalISR" class="btn btn-info"/>
                 <div class="modal" id="myModalISR">
                    <div class="modal-dialog">
                        <div class="modal-content">

                            <!-- Encabezado Modal -->
                            <div class="modal-header">
                                <h4 class="modal-title">Calculo del ISR</h4>
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                            </div>

                            <!-- Curepo de la Modal -->
                            <div class="modal-body">
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label17" runat="server" Text="Limite Inferior:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lblimiteinferior" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label19" runat="server" Text="Limite Superior:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lblimitesuperior" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            

                            
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label21" runat="server" Text="Cuota Fija:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbcuota" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            

                           
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label23" runat="server" Text="Excedente:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbexcedente" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            

                           
                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label25" runat="server" Text="Subsidio:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbsubsidio" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-xs-4 text-right">
                                        <h4>
                                            <asp:Label ID="Label18" runat="server" Text="Impuesto:" CssClass="label label-default form-control"></asp:Label>
                                        </h4>

                                    </div>
                                    <div class="col-xs-3">
                                        <asp:Label ID="lbisr" runat="server" Text="" CssClass="form-control"></asp:Label>
                                    </div>
                                </div>
                            </div>

                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div>
            <div>
                <a href="Index.aspx">Regresar</a>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        function ajaxISR() {
            var urlws = 'http://localhost:57657/AlumnosWS.asmx/CalcularISR';
            var alumno = { id: <%=lbid.Text%> };
            var parametros = JSON.stringify(alumno);

            $.ajax({
                type: 'POST',
                url: urlws,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: RecibeObjeto,
                error: errorGenerico
            });

        }

        function RecibeObjeto(resultado, estatus, jqXHR) {
            try {
                isr = resultado.d;
                if (isr != null) {
                    $("#<%=lblimiteinferior.ClientID%>").text("$"+isr.Límite_inferior);
                    $("#<%=lblimitesuperior.ClientID%>").text("$" +isr.Límite_superior);
                    $("#<%=lbcuota.ClientID%>").text("$" +isr.CuotaFija);
                    $("#<%=lbexcedente.ClientID%>").text("$" +isr.Excedente);
                    $("#<%=lbsubsidio.ClientID%>").text("$" +isr.Subsidio);
                    $("#<%=lbisr.ClientID%>").text("$" +isr.ISR);
                }
                else {
                    alert('La respuesta recibida es incorrecta ' + resultado.d);
                }

            }
            catch (ex) {
                alert('Error al recibir los datos');
            }
        }

        function errorGenerico(jqXHR, estatus, error) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }
    </script>
</asp:Content>
