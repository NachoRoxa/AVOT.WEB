<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits="AVOT.WEB.RecuperarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
    <div class="row">
        <div class="col-sm-4">
        </div>
        <div class="col-sm-4">
            <div class="form-group">
                <label for="Correo">Correo:</label>
                <asp:TextBox class="form-control" ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="btnEnviar" class="btn btn-default" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <div class="col-sm-4">
        </div>
    </div>
</asp:Content>
