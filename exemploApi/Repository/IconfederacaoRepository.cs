using exemploApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public interface IconfederacaoRepository
    {
        Task<IEnumerable<confederacao>> ObterTodos();
        Task<confederacao> ObterPorId(int id);
        Task Adicionar(confederacao reserva);
        Task Atualizar(confederacao reserva);
        void Deletar(int id);
    }
}
