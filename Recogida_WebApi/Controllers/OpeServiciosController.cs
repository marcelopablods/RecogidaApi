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
    public class OpeServiciosController : ApiController
    {
        [HttpGet]
        public IEnumerable<OpeServicio> obtenerServicio(int IdOpeGuia, string fecha)
        {
            IList<OpeServicio> listaopeServicio = new List<OpeServicio>();
            DataSet ds = Conexion.ejecutar_select("Sp_WebEncuesta_RescataServicios_Recogida '" + IdOpeGuia + "','" + fecha + "'");
            OpeServicio servicios = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    servicios = new OpeServicio();
                    servicios.idOpeServicio = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    servicios.descripcion = ds.Tables[0].Rows[i][1].ToString();
                    servicios.fechaHoraInicio = ds.Tables[0].Rows[i][2].ToString();
                    listaopeServicio.Add(servicios);
                }
            }
            else
            {
                servicios = new OpeServicio();
                servicios.idOpeServicio = 0;
                servicios.descripcion = "";
                servicios.fechaHoraInicio = "";

            }
            return listaopeServicio;

        }
    }
}
