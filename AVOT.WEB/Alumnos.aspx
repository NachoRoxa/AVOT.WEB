<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="AVOT.WEB.Alumnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
    <div class="row">
        <div class="col-sm-3">
        </div>
        <div class="col-sm-6">
            <asp:GridView ID="gdvAlumnos" runat="server" class="table" BackColor="white" BorderColor="Red" ForeColor="Black" HeaderStyle-BackColor="Red" HeaderStyle-ForeColor="Black">
            </asp:GridView>
        </div>
        <div class="col-sm-3">
        </div>
    </div>
</asp:Content>
