<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="ActualizarContraseña.aspx.cs" Inherits="AVOT.WEB.ACtualizarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
    <div class="row">
        <div class="col-sm-3">
        </div>
        <div class="col-sm-6">
            <legend class="text-center header">ESCRIBA LA CONTRASEÑA PARA ACTUALIZAR SU CUENTA:</legend>
            <div class="form-group">
                <label>Nueva Contraseña:</label>
                <asp:TextBox ID="txtNewPass" runat="server" TextMode="Password" class="form-control"></asp:TextBox><p />
                <label>Repita Contraseña:</label>
                <asp:TextBox ID="txtRePass" runat="server" TextMode="Password" class="form-control"></asp:TextBox><p />
                <p />
                <asp:Label ID="lblError" runat="server" Text="" Class="glyphicon-text-color"></asp:Label><p />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" class="btn btn-default text-center" />
            </div>
            <div class="col-sm-3">
            </div>
        </div>
    </div>
</asp:Content>
