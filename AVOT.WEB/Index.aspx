<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestras/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AVOT.WEB.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InfoPagina" runat="server">
    <div class="row container-fluid mx-auto">
        <div class="col-sm-6 col-md-4">
            <div class="thumbnail">
                <img src="Imagenes/IslaDePascua.jpg" alt="...">
                <div class="caption">
                    <h3>Isla de Pascua</h3>
                    <p>
                        Isla de Pascua o Rapa Nui es una isla de Polinesia situada en pleno océano Pacífico.
                        Perteneciente a Chile, es uno de los principales destinos turísticos del país.
                        Rapa Nui cuenta con un solo pueblo, Hanga Roa, lugar donde se concentran casi todos los habitantes de la isla.
                        Sin duda, se trata de un lugar único e idílico debido a su naturaleza, cultura e historia.
                    </p>
                    <p>
                        <a href="Destinos.aspx" class="btn btn-primary" role="button">+</a>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-4">
            <div class="thumbnail">
                <img src="Imagenes/Chiloe2.jpg" alt="...">
                <div class="caption">
                    <h3>Chiloe</h3>
                    <p>
                        Chiloé es una tierra de encanto y de costumbres Chilenas de antaño.
                        Esta "región" dentro de la Región de los Lagos, tiene un gran atractivo por su cultura propia,
                        característica, distintiva y reconocible por lo visitantes, que más que recibir, ha exportado
                        personas y costumbres a otras zonas, con gran influencia de Chilotes migrados a Patagonia Magallanes.
                    </p>
                    <p>
                        <a href="Destinos.aspx" class="btn btn-primary" role="button">+</a>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-4">
            <div class="thumbnail">
                <img src="Imagenes/torres.jpg" alt="...">
                <div class="caption">
                    <h3>Torres del paine</h3>
                    <p>Torres del Paine es probablemente el mayor ícono del turismo de Chile para los extranjeros. 
                        Dentro de la Patagonia es un destino obligado si se quiere decir que uno ha estado en la Patagonia. 
                        Junto a El Chaltén y El Calafate, ciudades que conforman el Parque Nacional Los Glaciares y a Ushuaia,
                        todos los anteriores en Argentina, Torres del Paine es el mayor lugar de atracción de la Patagonia total.</p>
                    <p>
                        <a href="Destinos.aspx" class="btn btn-primary" role="button">+</a>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
