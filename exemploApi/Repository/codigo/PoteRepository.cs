using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public class PoteRepository : IPoteRepository
    {
		private AppDbContext _context = null;

		public PoteRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(Pote Pote)
		{
			await _context.Pote.AddAsync(Pote);
			await _context.SaveChangesAsync();

		}

		public async Task Atualizar(Pote Pote)
		{
			_context.Pote.Update(Pote);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int id)
		{
			var entity = await ObterPorId(id);
			_context.Pote.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<Pote> ObterPorId(int id)
		{
			return await _context.Pote.FindAsync(id);
		}

		public async Task<IEnumerable<Pote>> ObterTodos()
		{
			return await _context.Pote.AsNoTracking().ToListAsync();
		}
	}
}
