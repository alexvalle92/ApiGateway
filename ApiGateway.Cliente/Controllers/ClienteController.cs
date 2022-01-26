using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway.Cliente.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private static readonly string[] Clientes = new[]
        {
            "Alexandre", "Rafael", "Tamili", "Joao", "Gabriel"
        };

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Clientes);
        }

        [HttpGet("{id:int}", Name = "Get")]
        public IActionResult Get(int id)
        {
            if (id > Clientes.Length - 1)
                id = Clientes.Length - 1;
            return Ok(Clientes[id]);
        }
    }
}
