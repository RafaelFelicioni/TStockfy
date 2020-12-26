using System.Collections.Generic;
using System.Threading.Tasks;
using TStockfy.Model;

namespace TStockfy.Repository.Interfaces
{
    public interface IVendaRepository
    {
        ValueTask<Venda> GetById(int vendaId);
        Task AddVenda(Venda venda);
        Task UpdateVenda(Venda venda, int vendaId);
        Task RemoveVenda(int vendaId);
        Task<IEnumerable<Venda>> GetAllVendas();
    }
}
