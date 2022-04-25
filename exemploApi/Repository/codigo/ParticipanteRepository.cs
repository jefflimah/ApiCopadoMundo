using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public class ParticipanteRepository : IParticipanteRepository
	{
		private AppDbContext _context = null;

		public ParticipanteRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(participante participante)
		{
			await _context.participante.AddAsync(participante);
			await _context.SaveChangesAsync();

		}

		public async Task Atualizar(participante participante)
		{
			_context.participante.Update(participante);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int id)
		{
			var entity = await ObterPorId(id);
			_context.participante.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<participante> ObterPorId(int id)
		{
			return await _context.participante.FindAsync(id);
		}

		public async Task<IEnumerable<participante>> ObterTodos()
		{
			return await _context.participante.AsNoTracking().ToListAsync();
		}
	}
}
