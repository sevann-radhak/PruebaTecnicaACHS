using System.Collections.Generic;

namespace PruebaTecnicaACHS.Models
{
    public class RestfulResponse
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public List<AgencyEntity> Result { get; set; }
    }
}
