using Newtonsoft.Json;
using SharedModels.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class NominaRepository : INominaRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;
        public NominaRepository(HttpClient httpClient, string endpoint)
        {
            _httpClient = httpClient;
            _endpoint = endpoint;
        }
        public async Task<IEnumerable<NominaCompletaDto>> GetNominaGeneral()
        {
            var response = await _httpClient.GetAsync(_endpoint);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<NominaCompletaDto>>(content);
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception(errorResponse);
            }
        }
    }
}
