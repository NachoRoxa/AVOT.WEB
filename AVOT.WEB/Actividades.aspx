<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="Actividades.aspx.cs" Inherits="AVOT.WEB.PaginasMaestras.Actividades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <div class="row">
        <div class="col-sm-3">
        </div>
        <div class="col-sm-6">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="upGVHojas" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <asp:GridView ID="gvActividades" runat="server" AutoGenerateColumns="False" Font-Size="X-Small" BackColor="White"
                        HeaderStyle-BackColor="Brown" HeaderStyle-ForeColor="white" ForeColor="Black" BorderColor="#339933"
                        CellPadding="1" CellSpacing="10" ShowFooter="True"  HorizontalAlign="Left" FooterStyle-HorizontalAlign="Center"
                        ShowHeaderWhenEmpty="True" ShowHeader="true">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btnBorrarGV" Text="Eliminar" ToolTip="Eliminar actividad de la base de datos"
                                        runat="server" OnClientClick="return validarDelete();" OnClick="BorrarEntrada" Font-Bold="true" ForeColor="Red" Font-Size="Smaller" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="COLEGIO">
                                <FooterTemplate>
                                    <asp:Button ID="btnAgregarActividad" runat="server" OnClientClick="return confirm('¿Desea agregar una nueva nueva actividad')" OnClick="AgregarActividad"
                                        Text="Agregar actividad"
                                        ToolTip="Agregar una nueva actividad para el curso" />
                                </FooterTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblColegioGV" runat="server" Width="200px" AutoPostBack="false" Font-Size="X-Small">
                                    </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="CURSO">
                                <ItemTemplate>
                                    <asp:Label ID="lblCurso" runat="server" Width="130px" AutoPostBack="true" Font-Size="X-Small">
                                    </asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ACTIVIDAD">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtActividadGV" runat="server"
                                        DataTextField="DESCRIPCION" DataValueField="ID_ACTIVIDAD" Width="500px"
                                        Font-Size="X-Small" AutoPostBack="false">
                                    </asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="INVERSION">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtInversionGV" runat="server" Width="100px"
                                        MaxLength="8" onPaste="return false">
                                    </asp:TextBox>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="RECAUDACION">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtRecaudacionGV" runat="server" Width="100px"
                                        MaxLength="8" AutoPostBack="false" onkeypress="" onPaste="return false"></asp:TextBox>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="MONTO DEPOSITO">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtMontoDepositoGV" runat="server" Width="100px"
                                        MaxLength="8" AutoPostBack="false" onPaste="return false"></asp:TextBox>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="NUMERO DEPOSITO">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtNumDepositoGV" runat="server" Width="200px"
                                        MaxLength="20" AutoPostBack="false" onPaste="return false"></asp:TextBox>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                <FooterTemplate>
                                    <asp:Button ID="btnGuardar" runat="server" OnClientClick="return confirm('¿Guardar cambios?')" OnClick="GuardarCambios"
                                        Text="Guardar"
                                        ToolTip="Guardar cambios en la base de datos" />
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle Font-Bold="True" BorderStyle="Solid" BorderWidth="1px" Font-Size="Medium" Font-Italic="False" />
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="col-sm-3">
        </div>
    </div>


    <script type="text/javascript">

        function validarDelete() {
            return confirm('¿Está seguro que quiere eliminar esa actividad?');
        }

        (function () {
            var focusElement;
            function restoreFocus() {
                if (focusElement) {
                    if (focusElement.id) {
                        $('#' + focusElement.id).focus();
                        $('#' + focusElement.id).select();
                    } else {
                        $(focusElement).focus()
                        $(focusElement).select();
                    }
                }
            }

            $(document).ready(function () {
                $(document).on('focusin', function (objectData) { focusElement = objectData.currentTarget.activeElement; });
                Sys.WebForms.PageRequestManager.getInstance().add_endRequest(restoreFocus);
            });
        })();




        function chkNumeroDecimal(obj) {
            obj.value = obj.value.replace(/[^\d\.]/g, "").replace(/\./, "x").replace(/\./g, "").replace(/x/, ".");
        }




        function setHorasParseadas(obj) {
            try {
                var isValido = true;
                var aux = obj.value;
                if (aux < 0 || aux > 24) {
                    isValido = false;
                    aux = 0;

                }
                else {
                    if (aux > Math.floor(aux)) {
                        if (aux <= (Math.floor(aux) + .4)) {
                            aux = (Math.floor(aux) + .25);
                        }
                        else if (aux > (Math.floor(aux) + .4) && aux <= (Math.floor(aux) + .6)) {
                            aux = (Math.floor(aux) + .5);
                        }
                        else {
                            aux = (Math.floor(aux) + .75);
                        }
                    }
                }
                obj.value = aux;
                if (!isValido) {
                    alert("No puede ser un numero mayor a 24");
                }
            } catch (e) {
                alert(e);
            }

        }

    </script>
</asp:Content>
