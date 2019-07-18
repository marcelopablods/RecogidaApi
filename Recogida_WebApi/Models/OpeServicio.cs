using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Encuesta.Models
{
    public class OpeServicio
    {
        public int idOpeServicio { get; set; }
        public int idOpeVehiculo { get; set; }
        public int idOpeConductor { get; set; }
        public int idOpeGuia { get; set; }
        public int idClieCliente_OpeServicio { get; set; }
        public int idProvProveedores { get; set; }
        public int idSegUsuario_OpeServicio { get; set; }
        public int idOpeTipoServicio { get; set; }
        public int idOpeTipoEstadoServicio_OpeServicio { get; set; }
        public string pasajero_OpeServicio { get; set; }
        public string descripcion { get; set; }
        public string montoTarifa { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public int kmFin { get; set; }
        public string noVueloHora { get; set; }
        public int kmInicio { get; set; }
        public int noPasajeros { get; set; }
        public int noPasajerosPagados { get; set; }
        public int noPasajerosReservador { get; set; }
        public string observacion { get; set; }
        public string fechaHoraInicio { get; set; }
        public string fechaHoraFin { get; set; }
        public string fechaHoraInicioReal { get; set; }
        public string fechaHoraFinReal { get; set; }
        public int idMaeEmpresaGrupo_OpeServicio { get; set; }
        public int idOpeTipoVehiculo { get; set; }
        public bool incluyeGuia { get; set; }
        public bool incluyeAgua { get; set; }
        public bool incluyeEntradas { get; set; }
        public bool incluyeOtros { get; set; }
        public bool incluyeObs { get; set; }
        public int idOpeAcercamiento { get; set; }
        public int idVentaNegocio { get; set; }
        public int idOpeConductor2 { get; set; }
        public int idProdSubTipoProducto { get; set; }
        public bool estado { get; set; }
        public string agencia { get; set; }
        public bool incluyeComidas { get; set; }
        public bool incluyeTourVinos { get; set; }
        public int idProdCosto { get; set; }
        public bool esModificado { get; set; }
        public int idMaeIdiomasServicio { get; set; }
        public string clienteOperador { get; set; }
        public int idOpeGuia2 { get; set; }
        public string contacto { get; set; }

    }
}