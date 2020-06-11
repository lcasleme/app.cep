using domain.Entities;

namespace service.Interfaces
{
    public interface IAddressService
    {
        Address GetAddress(string cep);
    }
}