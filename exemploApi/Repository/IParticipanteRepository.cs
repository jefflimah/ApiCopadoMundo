using exemploApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public interface IParticipanteRepository

    {
        Task<IEnumerable<participante>> ObterTodos();
        Task<participante> ObterPorId(int id);
        Task Adicionar(participante reserva);
        Task Atualizar(participante reserva);
        void Deletar(int id);
    }
}
