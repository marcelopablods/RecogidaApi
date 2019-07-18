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
    public class OpeGuiasController : ApiController
    {
        [HttpGet]
        public IEnumerable<OpeGuia> obtenerGuia(string fecha)
        {
            IList<OpeGuia> listaopeGuia = new List<OpeGuia>();
            DataSet ds = Conexion.ejecutar_select("Sp_WebEncuesta_RescataGuias '" + fecha + "'");
            OpeGuia guias = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    guias = new OpeGuia();
                    guias.idOpeGuia = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    guias.nombre = ds.Tables[0].Rows[i][1].ToString();
                    listaopeGuia.Add(guias);
                }
            }
            else
            {
                guias = new OpeGuia();
                guias.idOpeGuia = 0;
                guias.nombre = "";

            }
            return listaopeGuia;

        }
    }
}
