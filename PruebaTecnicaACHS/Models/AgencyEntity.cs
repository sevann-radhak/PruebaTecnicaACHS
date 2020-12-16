using System.Collections.Generic;

namespace PruebaTecnicaACHS.Models
{
    public class AgencyEntity
    {
        public string Contacto { get; set; }
        public string Comuna { get; set; }
        public string HorarioApertura { get; set; }
        public string HorarioCierre { get; set; }
        public string Region { get; set; }
        public string Sedes { get; set; }
        public List<string> Servicios { get; set; }
    }
}
