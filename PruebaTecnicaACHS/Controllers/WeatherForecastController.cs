using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PruebaTecnicaACHS.Models;
using System;

namespace PruebaTecnicaACHS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class achsController : ControllerBase
    {
        private readonly ILogger<achsController> _logger;

        public achsController(ILogger<achsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public RestfulResponse Get()
        {
            try
            {
                string path = @"./Data/data.json";
                using (System.IO.StreamReader jsonStream = System.IO.File.OpenText(path))
                {

                    string json = jsonStream.ReadToEnd();
                    DataResponse data = JsonConvert.DeserializeObject<DataResponse>(json);

                    return new RestfulResponse
                    {
                        IsSuccess = true,
                        Result = data.Data
                    };

                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);

                return new RestfulResponse
                {
                    IsSuccess = false,
                    Message = "Error al leer la información."
                };
            }
        }
    }
}
