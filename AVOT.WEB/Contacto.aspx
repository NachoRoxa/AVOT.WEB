<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="AVOT.WEB.Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
     <div class="row">
        <div class="col-sm-3">
        </div>
         <div class="col-sm-6">
             <legend class="text-center header">Contactenos</legend>
             
                 <div class="form-group">
                     <asp:TextBox class="form-control" id="txtNombre" placeholder="Nombre" runat="server"></asp:TextBox>
                 </div>
                <div class="form-group">
                    <asp:TextBox class="form-control" id="txtApellido" placeholder="Apellido" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox class="form-control" id="txtCorreo" placeholder="Correo electronico" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox class="form-control" id="txtTelefono" placeholder="Telefono contacto" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox class="form-control" id="txtComentarios" placeholder="Comentarios" runat="server"></asp:TextBox>
                </div>
                <div class="form-group text-center">
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" class="btn btn-default" />
                </div>
        </div>
        <div class="col-sm-3">
        </div>
    </div>
</asp:Content>
