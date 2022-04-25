using exemploApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public interface IgrupoParticipanteRepository
    {
        Task<IEnumerable<grupoParticipante>> ObterTodos(int idGrupo);
        Task<grupoParticipante> ObterPorId(int id);
        Task Adicionar(grupoParticipante reserva);
        Task Atualizar(grupoParticipante reserva);
        void Deletar(int id);
    }
}
