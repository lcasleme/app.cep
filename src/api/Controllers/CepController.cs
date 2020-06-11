using domain.Entities;
using Microsoft.AspNetCore.Mvc;
using service.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        [HttpGet("{cep}")]
        public Address Get([FromServices] IAddressService addressService, string cep)
        {
            return addressService.GetAddress(cep);
        }
    }
}