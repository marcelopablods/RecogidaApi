using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Encuesta.Models
{
    public class OpeServicioDetalle
    {
        public int idOpeServicioDetalle { get; set; }
        public int idOpeServicio { get; set; }
        public int idMaeEmpresaGrupo { get; set; }
        public int idOpeTipoServicio { get; set; }
        public int idVentaTipoPago { get; set; }
        public int idMaeIdiomas { get; set; }
        public int chequeo { get; set; }
        public int idOpeAcercamientoDetalle { get; set; }
        public int idVentaRegularDetalle { get; set; }
        public string pasajero { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string fechaHoraInicio { get; set; }
        public string montoTarifa { get; set; }
        public int noPaxAdulto { get; set; }
        public int noPaxChild { get; set; }
        public int noPasajerosPagados { get; set; }
        public int noPasajerosReservados { get; set; }
        public string direccionOrigen { get; set; }
        public string direccionDestino { get; set; }
        public string noHabitacion { get; set; }
        public int comidas { get; set; }
        public int entradas { get; set; }
        public int tourVinos { get; set; }
        public int otros { get; set; }
        public int idVenEstadoWF { get; set; }
        public bool clienteIndicaPago { get; set; }
        public string noVueloHora { get; set; }
        public string observaciones { get; set; }
        public int idProdSubTipoProducto { get; set; }
        public bool incluyeObs { get; set; }
        public bool estado { get; set; }
        public bool incluyeGuia { get; set; }
        public bool incluyeAgua { get; set; }
        public bool incluyeEntradas { get; set; }
        public bool incluyeTourVinos { get; set; }
        public bool incluyeComidas { get; set; }
        public bool incluyeOtros { get; set; }
        public int idVentaRegular { get; set; }
        public int idVentaRegularDetalleItinerario { get; set; }
        public int idProdCosto { get; set; }
        public int idProdProducto { get; set; }
        public int idProdPrograma { get; set; }
        public string clienteOperador { get; set; }
        public int idMaeIdiomasServicio { get; set; }
        public string contacto { get; set; }
        public bool esRecogida { get; set; }
        public string fechaHoraRecogida { get; set; }
        public string recogidaObs { get; set; }

        //Adicional

        public string cantidad { get; set; }
        public string idioma { get; set; }

    }
}