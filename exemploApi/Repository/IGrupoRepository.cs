using exemploApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploApi.Repository
{
    public interface IgrupoRepository
    {
        Task<IEnumerable<grupo>> ObterTodos();
        Task<grupo> ObterPorId(int id);
        Task Adicionar(grupo reserva);
        Task Atualizar(grupo reserva);
        void Deletar(int id);
    }
}
