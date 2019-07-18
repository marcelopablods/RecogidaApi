using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Encuesta.Models;
using WebApi.Models;

namespace Encuesta.Controllers
{
    public class OpeServicioDetallesController : ApiController
    {
        [HttpGet]
        public IEnumerable<OpeServicioDetalle> obtenerPasajero(int IdOpeServicio)
        {
            IList<OpeServicioDetalle> listapasajeros = new List<OpeServicioDetalle>();
            DataSet ds = Conexion.ejecutar_select("Sp_WebEncuesta_RescataPasajeros_Recogida '" + IdOpeServicio + "'");
            OpeServicioDetalle pasajeros = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    pasajeros = new OpeServicioDetalle();
                    pasajeros.idOpeServicioDetalle = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    pasajeros.idVentaRegular = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                    pasajeros.pasajero = ds.Tables[0].Rows[i][2].ToString();
                    pasajeros.cantidad = ds.Tables[0].Rows[i][3].ToString();
                    pasajeros.idioma = ds.Tables[0].Rows[i][4].ToString();
                    listapasajeros.Add(pasajeros);
                }
            }
            else
            {
                pasajeros = new OpeServicioDetalle();
                pasajeros.idOpeServicioDetalle = 0;
                pasajeros.idVentaRegular = 0;
                pasajeros.pasajero = "";
                pasajeros.cantidad = "";
                pasajeros.idioma = "";

            }
            return listapasajeros;

        }

    }
}
