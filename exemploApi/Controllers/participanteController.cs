using exemploApi.Models;
using exemploApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Controllers
{
	[Route("api/[controller]")]
    public class participanteController : Controller
    {
		private readonly IParticipanteRepository _repository;

        public participanteController(IParticipanteRepository repository)
        {
			_repository = repository;

		}

		[HttpGet]
		[Route("ola")]
		public async Task<ActionResult> ola()
		{
			return Ok("Ola API ON!");
		}

		[HttpGet]
		[Route("ObterTodos")]
		public async Task<ActionResult<IEnumerable<participante>>> ObterTodos()
		{

			var participante = await _repository.ObterTodos();

			if (participante == null)
			{
				return NotFound();
			}

			return Ok(participante);
		}


		[HttpGet]
		[Route("ObterPorId/id")]
		public async Task<ActionResult<IEnumerable<participante>>> ObterPorId(int id)
		{

			var participante = await _repository.ObterPorId(id);

			if (participante == null)
			{
				return NotFound();
			}

			return Ok(participante);
		}

		[HttpPost]
		[Route("Adicionar")]
		public async Task<ActionResult<IEnumerable<participante>>> Adicionar(participante p)
		{

			if (p == null)
			{
				return BadRequest();
			}

			await _repository.Adicionar(p);

			return Ok("Participante cadastro com sucesso");
		}

		[HttpPut]
		[Route("Atualizar/id")]
		public async Task<ActionResult<IEnumerable<participante>>> Atualizar(int id , participante p)
		{
			var participanteAux = _repository.ObterPorId(id);

			if (participanteAux == null)
			{
				return NotFound();
			}
			p.participantesID = id;
			await _repository.Atualizar(p);

			return Ok("Participante atualizado com sucesso");
		}


		[HttpDelete]
		[Route("Deletar/id")]
		public async Task<ActionResult<IEnumerable<participante>>> Deletar(int id)
		{
			var participanteAux = _repository.ObterPorId(id);

			if (participanteAux == null)
			{
				return NotFound();
			}
			
			_repository.Deletar(id);

			return Ok("Participante deletado com sucesso");
		}
	}
}
