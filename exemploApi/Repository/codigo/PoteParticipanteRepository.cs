using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public class PoteParticipanteRepository
	{
		private AppDbContext _context = null;

		public PoteParticipanteRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(PoteParticipante PoteParticipante)
		{
			await _context.PoteParticipante.AddAsync(PoteParticipante);
			await _context.SaveChangesAsync();

		}

		public async Task Atualizar(PoteParticipante PoteParticipante)
		{
			_context.PoteParticipante.Update(PoteParticipante);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int idPote, int idParticipante)
		{
			var entity = await
						  _context.PoteParticipante
						  .Where(
							   p => p.PoteID == idPote &&
								   p.participantesID == idParticipante

							  )
						     .FirstAsync();

			_context.PoteParticipante.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<PoteParticipante> ObterPorId(int id)
		{
			return await _context.PoteParticipante.FindAsync(id);
		}

		public async Task<IEnumerable<PoteParticipante>> ObterTodos(int IdPote)
		{
			return await _context.PoteParticipante.AsNoTracking().Where(g => g.PoteID == IdPote).ToListAsync();
		}
	}
}

