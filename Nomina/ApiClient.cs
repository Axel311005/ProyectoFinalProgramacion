using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        public IRepository<EmpleadoDto> Empleados { get; }
        public IRepository<DeduccionDto> Deducciones { get; }

        public ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _httpClient = new HttpClient { BaseAddress = new Uri(apiBaseUrl)};
            Empleados= new Repository<EmpleadoDto>(_httpClient, "Empleado");
            Deducciones = new Repository<DeduccionDto>(_httpClient, "Deduccion");
        }
    }
}
