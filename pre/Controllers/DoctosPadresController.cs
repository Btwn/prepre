using Microsoft.AspNetCore.Mvc;
using pre.Modelos;
using pre.Repositories;
using System.Collections.Generic;

namespace pre.Controllers
{
    [ApiController]
    [Route("[controller]/{cuenta?}")]
    public class DoctosPadresController : ControllerBase
    {
        [HttpGet(Name = "GetDoctosPadres")]
        public IEnumerable<DoctosPadres> Get(string cuenta)
        {
            IClienteRepository repository = new ClienteTestRepository("");
            return repository.BuscarDoctosPadresXCuenta(cuenta);
        }
    }
}
