using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public class confederacaoRepository : IconfederacaoRepository
    {
		private AppDbContext _context = null;

		public confederacaoRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(confederacao confederacao)
		{
			await _context.confederacao.AddAsync(confederacao);
			await _context.SaveChangesAsync();

		}

		public async Task Atualizar(confederacao confederacao)
		{
			_context.confederacao.Update(confederacao);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int id)
		{
			var entity = await ObterPorId(id);
			_context.confederacao.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<confederacao> ObterPorId(int id)
		{
			return await _context.confederacao.FindAsync(id);
		}

		public async Task<IEnumerable<confederacao>> ObterTodos()
		{
			return await _context.confederacao.AsNoTracking().ToListAsync();
		}
	}
}

