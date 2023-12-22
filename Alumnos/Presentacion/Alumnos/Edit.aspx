<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Actualizar Alumno </h2>

    <div>
        <div>
            <!---->
            <div class="row">
                <div class="col-xs-2 text-right">
                    <h4>
                        <asp:Label ID="Label2" runat="server" Text="ID:" CssClass="label label-default"></asp:Label>
                    </h4>

                </div>
                <div class="col-xs-3">
                    <asp:TextBox ID="tbid" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <!---->
             <div class="row">
                <div class="col-xs-2 text-right">
                    <h4>
                        <asp:Label ID="Label1" runat="server" Text="Nombre:" CssClass="label label-default"></asp:Label>
                    </h4>

                </div>
                <div class="col-xs-3">
                    <asp:TextBox ID="tbnombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                 <!--Validacion-->
                <div>
                    <asp:RequiredFieldValidator ID="requeridonombre" runat="server" ErrorMessage="El campo Nombre es obligatorio" ControlToValidate="tbnombre" CssClass="alert-danger"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="varenombre" runat="server" ErrorMessage="Proporciona un nombre correcto" ControlToValidate="tbnombre" CssClass="alert-danger"
                            ValidationExpression="[a-zA-ZÁÉÍÓÚáéíóúñÑ]+(\s*[a-zA-ZÁÉÍÓÚáéíóúñÑ]*)*[a-zA-ZÁÉÍÓÚáéíóúñÑ]+$"></asp:RegularExpressionValidator>
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
                    <asp:TextBox ID="tbprimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <!--Validacion-->
                <div >
                        <asp:RequiredFieldValidator ID="requeridoprimerApellido1" runat="server" ErrorMessage="El campo Primer Apellido es obligatorio" ControlToValidate="tbprimerApellido" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="vareprimerApellido" runat="server" ErrorMessage="Proporciona un apelido correcto" ControlToValidate="tbprimerApellido" CssClass="alert-danger"
                            ValidationExpression="[a-zA-ZÁÉÍÓÚáéíóúñÑ]+(\s*[a-zA-ZÁÉÍÓÚáéíóúñÑ]*)*[a-zA-ZÁÉÍÓÚáéíóúñÑ]+$"></asp:RegularExpressionValidator>
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
                    <asp:TextBox ID="tbsegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <!--Validacion-->
                <div>
                    <asp:RegularExpressionValidator ID="varesegundoapellido" runat="server" ErrorMessage="Proporciona un apelido correcto" ControlToValidate="tbsegundoApellido" CssClass="alert-danger"
                            ValidationExpression="[a-zA-ZÁÉÍÓÚáéíóúñÑ]+(\s*[a-zA-ZÁÉÍÓÚáéíóúñÑ]*)*[a-zA-ZÁÉÍÓÚáéíóúñÑ]+$"></asp:RegularExpressionValidator>
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
                    <asp:TextBox ID="tbcorreo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <!--Validacion-->
                <div>
                    <asp:RequiredFieldValidator ID="requeridocorreo" runat="server" ErrorMessage="El campo Correo es obligatorio" ControlToValidate="tbcorreo" CssClass="alert-danger"></asp:RequiredFieldValidator>
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
                    <asp:TextBox ID="tbtelefono" runat="server" CssClass="form-control"></asp:TextBox>
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
                    <asp:TextBox ID="tbfechaNacimiento" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                </div>
                <div>
                     <asp:RequiredFieldValidator ID="requeridofechanacimiento" runat="server" ErrorMessage="El campo Fecha de Nacimiento es obligatorio" ControlToValidate="tbfechaNacimiento" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                     <asp:RangeValidator ID="varfechanacimiento" runat="server" ErrorMessage="No te encuentras en el rango de edad requerido el cual es: 1983 al 2005 " ControlToValidate="tbfechaNacimiento" CssClass="alert-danger"
                        Type="Date" MaximumValue="2005-12-31" MinimumValue="1990-01-01"></asp:RangeValidator>
                </div>
            </div>
            <!---->
            <div class="row">
                <div class="col-xs-2 text-right">
                    <h4>
                        <asp:Label ID="Label8" runat="server" Text="CURP:" CssClass="label label-default"></asp:Label>
                    </h4>

                </div>
                <div class="col-xs-3">
                    <asp:TextBox ID="tbcurp" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <!--Validacion-->
                <div>
                    <asp:RequiredFieldValidator ID="requeridocurp" runat="server" ErrorMessage="El campo CURP es obligatorio" ControlToValidate="tbcurp" CssClass="alert alert-danger"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="vacurpYfecha" runat="server" ErrorMessage="La fecha de la CURP no coincide con la fecha de nacimiento" ControlToValidate="tbcurp" CssClass="alert alert-danger"
                        OnServerValidate="vacurpYfecha_ServerValidate"></asp:CustomValidator>
                    <asp:RegularExpressionValidator ID="varcurp" runat="server" ErrorMessage="La curp no tiene bien la estructura requerida" ControlToValidate="tbcurp" CssClass="alert-danger"
                        ValidationExpression="^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$"></asp:RegularExpressionValidator>
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
                    <asp:TextBox ID="tbsueldo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <!--Validacion-->
                <div>
                    <asp:RangeValidator ID="varsueldo" runat="server" ErrorMessage="El saldo debe estar entre 10,000 y 40,000 pesos" ControlToValidate="tbsueldo" CssClass="alert-danger"
                        type="Double" MinimumValue="10000.00" MaximumValue="40000.00"></asp:RangeValidator>
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
                    <asp:DropDownList ID="ddidestado" runat="server" CssClass="form-control"></asp:DropDownList>
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
                    <asp:DropDownList ID="ddidestatus" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <!---->
        </div>
    </div>

    <div>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" CssClass="btn btn-primary" />
    </div>

    <div>
        <a href="Index.aspx">Regresar</a>
    </div>

</asp:Content>
