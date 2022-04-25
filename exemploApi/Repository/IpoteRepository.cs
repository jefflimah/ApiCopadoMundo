using exemploApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
	public interface IPoteRepository
	{
		Task<IEnumerable<Pote>> ObterTodos();
		Task<Pote> ObterPorId(int id);
		Task Adicionar(Pote reserva);
		Task Atualizar(Pote reserva);
		void Deletar(int id);
	}
}
