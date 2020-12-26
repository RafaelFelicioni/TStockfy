using TStockfy.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TStockfy.Repository.Interfaces
{
    public interface IAcessoRepository
    {
        ValueTask<Acesso> GetById(int acessoId);
        Task AddAcesso(Acesso acesso);
        Task UpdateAcesso(Acesso acesso, int acessoId);
        Task RemoveAcesso(int acessoId);
        Task<IEnumerable<Acesso>> GetAllAcessos();
    }
}
