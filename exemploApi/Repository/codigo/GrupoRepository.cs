using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public class grupoRepository
	{
		private AppDbContext _context = null;

		public grupoRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(grupo grupo)
		{
			await _context.grupo.AddAsync(grupo);
			await _context.SaveChangesAsync();

		}

		public async Task Atualizar(grupo grupo)
		{
			_context.grupo.Update(grupo);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int id)
		{
			var entity = await ObterPorId(id);
			_context.grupo.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<grupo> ObterPorId(int id)
		{
			return await _context.grupo.FindAsync(id);
		}

		public async Task<IEnumerable<grupo>> ObterTodos()
		{
			return await _context.grupo.AsNoTracking().ToListAsync();
		}
	}
}

