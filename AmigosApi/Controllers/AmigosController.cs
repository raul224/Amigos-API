using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmigosCore;

namespace AmigosApi.Controllers
{
    [Route("api/amigos")]
    [ApiController]
    public class AmigosController : ControllerBase
    {
        private AmigoService _Service;

        public AmigosController(AmigoService service)
        {
            _Service = service;
        }

        [HttpGet("getAll")]
        public ActionResult GetAll()
        {
            var getAllAmigos = _Service.GetTodosAmigos();

            return Ok(getAllAmigos);
        }



        [HttpGet("{id:Guid}")]
        public ActionResult GetById([FromRoute] Guid id)
        {
            var pessoa = _Service.GetAmigo(id);

            if (pessoa == null)
                return NoContent();

            return Ok(pessoa);
        }

        [HttpPost]
        public ActionResult Pessoa([FromBody] AmigoRequest createAmigo)
        {
            var amigo = _Service.CadastrarAmigo(createAmigo);

            return Created("api/[controller]", amigo);
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _Service.RemoverAmigo(id);
            return NoContent();
        }


        [HttpPut("{id}")]
        public ActionResult Put([FromRoute] Guid id, AmigoRequest alterarAmigo)
        {
            var updatePessoa = _Service.AlterarAmigo(id, alterarAmigo);

            return Ok(updatePessoa);

        }
    }
}
