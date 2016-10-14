using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Contatos.Models;

namespace WebAPI_Contatos.Controllers
{
    [Route("api/[controller]")]
    public class ContatosController : Controller
    {
        public IContatosRepositorio contatosRepo { get; set; }

        public ContatosController(IContatosRepositorio _repo)
        {
            contatosRepo = _repo;
        }

        [HttpGet]
        public IEnumerable<Contato> GetTodos()
        {
            return contatosRepo.GetTodos();
        }

        [HttpGet("{id}", Name = "GetContatos")]
        public IActionResult GetPorID(string id)
        {
            var item = contatosRepo.Encontrar(id);
            if (item == null)
                return NotFound();

            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Contato item)
        {
            if (item == null)
                return BadRequest();

            contatosRepo.Adicionar(item);
            return CreatedAtRoute("GetContatos", new { Controller = "Contatos", id = item.Telefone }, item);
        }

        [HttpPut ("{id}")]
        public IActionResult Atualizar(string id, [FromBody] Contato item)
        {
            if (item == null)
                return BadRequest();

            var obj = contatosRepo.Encontrar(id);
            if (obj == null)
                return NotFound();

            contatosRepo.Atualizar(item);
            return new NoContentResult();
        }

        [HttpDelete ("{id}")]
        public void Deletar(string id)
        {
            contatosRepo.Remover(id);
        }
    }
}
