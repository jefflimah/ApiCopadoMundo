using exemploApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
	public interface IPoteParticipanteRepository
	{
		Task<IEnumerable<PoteParticipante>> ObterTodos(int idPote);
		Task<PoteParticipante> ObterPorId(int id);
		Task Adicionar(PoteParticipante reserva);
		Task Atualizar(PoteParticipante reserva);
		void Deletar(int idPote, int idParticipante);
	}
}
