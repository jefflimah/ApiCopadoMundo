using exemploApi.Models;
using exemploApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Controllers
{
	[Route("api/[controller]")]
	public class grupoController : Controller
    {

			private readonly IgrupoRepository _repository;
		    private readonly IgrupoParticipanteRepository _participanteRepository;

			public grupoController(IgrupoRepository repository, IgrupoParticipanteRepository participanteRepository)
			{
				_repository = repository;
				_participanteRepository = participanteRepository;

			}

			[HttpGet]
			[Route("ola")]
			public async Task<ActionResult> ola()
			{
				return Ok("Ola API ON!");
			}

			[HttpGet]
			[Route("ObterTodos")]
			public async Task<ActionResult<IEnumerable<grupo>>> ObterTodos()
			{

				var participante = await _repository.ObterTodos();

				if (participante == null)
				{
					return NotFound();
				}

				return Ok(participante);
			}

			[HttpGet]
			[Route("ObterParticipantesPorGrupo/{id}")]
			public async Task<ActionResult<IEnumerable<grupo>>> ObterParticipantesPorGrupo(int id)
			{

				var participantesDoGrupo = await _participanteRepository.ObterTodos(id);

				return Ok(participantesDoGrupo);
			}


			[HttpGet]
			[Route("ObterPorId/id")]
			public async Task<ActionResult<IEnumerable<grupo>>> ObterPorId(int id)
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
				public async Task<ActionResult<IEnumerable<grupo>>> Adicionar(grupo p)
				{

					if (p == null)
					{
						return BadRequest();
					}

					await _repository.Adicionar(p);

					return Ok("Participante cadastro com sucesso");
				}

				[HttpPost]
				[Route("AdicionarParticipante")]
				public async Task<ActionResult<IEnumerable<grupo>>> AdicionarParticipante(grupoParticipante p)
				{

					if (p == null)
					{
						return BadRequest();
					}

					await _participanteRepository.Adicionar(p);

					return Ok("Participante cadastro com sucesso");
				}

				[HttpPut]
				[Route("Atualizar/id")]
				public async Task<ActionResult<IEnumerable<grupo>>> Atualizar(int id, grupo p)
				{
					var participanteAux = _repository.ObterPorId(id);

					if (participanteAux == null)
					{
						return NotFound();
					}
					p.GrupoID = id;
					await _repository.Atualizar(p);

					return Ok("Participante atualizado com sucesso");
				}


				[HttpDelete]
				[Route("Deletar/id")]
				public async Task<ActionResult<IEnumerable<grupo>>> Deletar(int id)
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

