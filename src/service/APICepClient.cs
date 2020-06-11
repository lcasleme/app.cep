using domain.Entities.AppSettings;
using Microsoft.Extensions.Options;
using service.Interfaces;
using System.Net.Http;

namespace service
{
    public class APICepClient
    {
        private HttpClient _httpClient;
        private readonly IOptions<AppSettings> _appSettings;

        public APICepClient(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings;
        }

        public dynamic Get(string cep)
        {
            var response = _httpClient.GetAsync($"http://viacep.com.br/ws//{cep}/json").Result;
            var log = false;

            string resultado =
             response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
                log = true;
            //_logger.LogInformation("Resultado normal: " + resultado);
            else
                log = false;
            // _logger.LogError("Erro: " + resultado);

            response.EnsureSuccessStatusCode();
            return resultado;
        }
    }
}