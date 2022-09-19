using Microsoft.AspNetCore.Mvc;
using pre.Modelos;
using pre.Repositories;
using System.Collections.Generic;

namespace pre.Controllers
{
    [ApiController]
    [Route("[controller]/{cuenta?}")]
    public class ClienteController : ControllerBase
    {
        [HttpGet(Name = "GetCliente")]
        public IEnumerable<ClienteInfo> Get(string cuenta)
        {
            IClienteRepository repository = new ClienteTestRepository("");
            return repository.BuscarClienteXCuenta(cuenta);
        }
    }
}
