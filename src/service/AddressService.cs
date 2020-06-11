using domain.Entities;
using service.Interfaces;
using System.Text.Json;

namespace service
{
    public class AddressService : IAddressService
    {
        private readonly APICepClient _apiCepCliente;

        public AddressService(APICepClient apiCepCliente)
        {
            _apiCepCliente = apiCepCliente;
        }

        public Address GetAddress(string cep)
        {
            return JsonSerializer.Deserialize<Address>(_apiCepCliente.Get(cep));
        }
    }
}