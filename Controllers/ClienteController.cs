using ApiCliente.Data;
using ApiCliente.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.Controllers
{
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpGet]
        [Route("/cliente")]
        public IActionResult Get([FromServices] ApiDbContext context)
        {
            var clientes = context.Clientes.ToList();
            return Ok(clientes);
        }

        [HttpGet]
        [Route("/cliente/{id:int}")]
        public IActionResult GetById([FromRoute] int id, [FromServices] ApiDbContext context)
        {
            var cliente = context.Clientes.FirstOrDefault(x => x.Id == id);
            if (cliente == null)
                return NotFound();
            return Ok(cliente);
        }


        [HttpPost]
        [Route("/cliente")]
        public IActionResult Post([FromBody] Cliente cliente, [FromServices] ApiDbContext context)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return Ok("Cliente Salvo com sucesso!");
        }

        [HttpPut]
        [Route("/cliente/{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Cliente cliente, [FromServices] ApiDbContext context)
        {
            var clte = context.Clientes.FirstOrDefault(x => x.Id == id);
            if (clte == null)
                return NotFound();
            clte.Nome = cliente.Nome;
            clte.SobreNome = cliente.SobreNome;
            clte.DataNascimento = cliente.DataNascimento;
            context.Update(clte);
            context.SaveChanges();

            return Ok("Cliente Actualizado com sucesso!");

        }
        [HttpDelete]
        [Route("/cliente/{id:int}")]
        public IActionResult Delete([FromRoute] int id, [FromServices] ApiDbContext context)
        {
            var cliente = context.Clientes.FirstOrDefault(x => x.Id == id);

            if (cliente == null)
                return NotFound();
            context.Clientes.Remove(cliente);
            context.SaveChanges();

            return Ok("Cliente Removido com Sucesso!");
        }
    }
}