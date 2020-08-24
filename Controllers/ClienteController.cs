using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ProvaRestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult  GetClientes()
        {
            
            List<Modelos.Cliente> clientes = (new Business.Cliente()).GetAll();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            Modelos.Cliente cliente = (new Business.Cliente()).Get(id);
            //return JsonConvert.SerializeObject(endereco);
            return Ok(cliente);
        }
        [HttpPut("{id}")]
        public IActionResult PutCliente(int id, Modelos.Cliente clientes)
        {
            if (id != clientes.Id)
            {
                return BadRequest();
            }
            (new Business.Cliente()).Update(clientes);
            return NoContent();
        }

        [HttpPost]
        public IActionResult PostEndereco(Modelos.Cliente cliente)
        {
            (new Business.Cliente()).Add(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEndereco(int id,Modelos.Cliente cliente)
        {
            (new Business.Cliente()).Remove(cliente);
            return NoContent();
        }
    }
}