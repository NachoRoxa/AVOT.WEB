<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AVOT.WEB.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
    <div class="row">
        <div class="col-sm-3">
        </div>
        <div class="col-sm-6">
            <legend class="text-center header">Iniciar Sesion</legend>
                <div class="form-group">
                    <label for="Usuario">Ingrese Usuario:</label>
                    <asp:TextBox class="form-control" id="txtUsuario" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="Contraseña">Contraseña:</label>
                    <asp:TextBox type="password" ID="txtContraseña" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group text-center">
                    <asp:Label ID="lblMensajeError" runat="server"></asp:Label><p />
                    <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesion" class="btn btn-primary" OnClick="btnIniciarSesion_Click" />
                </div>
        </div>
        <div class="col-sm-3">
        </div>
    </div>
</asp:Content>
