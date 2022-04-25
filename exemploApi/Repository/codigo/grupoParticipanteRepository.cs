using exemploApi.Context;
using exemploApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public class grupoParticipanteRepository : IgrupoParticipanteRepository
	{
		private AppDbContext _context = null;

		public grupoParticipanteRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task Adicionar(grupoParticipante grupoParticipante)
		{
			await _context.grupoParticipante.AddAsync(grupoParticipante);
			await _context.SaveChangesAsync();

		}

		public async Task Atualizar(grupoParticipante grupoParticipante)
		{
			_context.grupoParticipante.Update(grupoParticipante);
			await _context.SaveChangesAsync();
		}

		public async void Deletar(int id)
		{
			var entity = await ObterPorId(id);
			_context.grupoParticipante.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<grupoParticipante> ObterPorId(int id)
		{
			return await _context.grupoParticipante.FindAsync(id);
		}


        public async Task<IEnumerable<grupoParticipante>> ObterTodos(int idGrupo)
        {
			return await _context.grupoParticipante.AsNoTracking().Where(g => g.GrupoID == idGrupo).ToListAsync();
		}
    }
}

