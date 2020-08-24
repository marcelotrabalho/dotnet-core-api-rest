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
    public class EnderecoController : ControllerBase
    {
        [HttpGet]
        public IActionResult  GetEnderecos()
        {
            
            List<Modelos.Cliente> enderecos = (new Business.Cliente()).GetAll();
            return Ok(enderecos);
        }

        [HttpGet("{id}")]
        public IActionResult GetEnderecos(int id)
        {
            Modelos.Cliente endereco = (new Business.Cliente()).Get(id);
            //return JsonConvert.SerializeObject(endereco);
            return Ok(endereco);
        }
        [HttpPut("{id}")]
        public IActionResult PutEndereco(int id, Modelos.Cliente enderecos)
        {
            if (id != enderecos.Id)
            {
                return BadRequest();
            }
            (new Business.Cliente()).Update(enderecos);
            return NoContent();
        }

        [HttpPost]
        public IActionResult PostEndereco(Modelos.Cliente endereco)
        {
            (new Business.Cliente()).Add(endereco);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEndereco(int id,Modelos.Cliente endereco)
        {
            (new Business.Cliente()).Remove(endereco);
            return NoContent();
        }

    }
}