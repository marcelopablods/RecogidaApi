using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Encuesta.Models
{
    public class OpeGuia
    {
        public int idOpeGuia { get; set; }
        public int idTipoOpeGuia { get; set; }
        public int idMaeDirecciones { get; set; }
        public int idOpeTipoNacGuia { get; set; }
        public int idOpeTipoJornadaGuia { get; set; }
        public string nombre { get; set; }
        public string rut { get; set; }
        public string fechaNacimiento { get; set; }
        public string telefonoFijo { get; set; }
        public string telefonoMovil { get; set; }
        public string email { get; set; }
        public string profesion { get; set; }
        public string cursos { get; set; }
        public bool primerosAuxilios { get; set; }
        public string vigencia { get; set; }
        public bool regulares { get; set; }
        public bool privadoIndividual { get; set; }
        public bool privadoGrupal { get; set; }
        public bool tarifaTuristour { get; set; }
        public string contactoEmergencia { get; set; }
        public string contactoTelefonoEmergencia { get; set; }
        public string centroAsistencial { get; set; }
        public string enfermedades { get; set; }
        public string alergias { get; set; }
        public string observaciones { get; set; }
        public int indicadorGuia { get; set; }
        public int rankingGeneral { get; set; }
        public int rankingIdiomas { get; set; }
        public int rankingTerreno { get; set; }
        public bool estado { get; set; }
        public int idMaeEmpresaGrupo { get; set; }

    }
}