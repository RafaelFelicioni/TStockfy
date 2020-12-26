using System.Collections.Generic;
using System.Threading.Tasks;
using TStockfy.Model;

namespace TStockfy.Repository.Interfaces
{
    public interface IFornecedorRepository
    {
        ValueTask<Fornecedor> GetById(int fornecedorId);
        Task AddFornecedor(Fornecedor fornecedor);
        Task UpdateFornecedor(Fornecedor fornecedor, int fornecedorId);
        Task RemoveFornecedor(int fornecedorId);
        Task<IEnumerable<Fornecedor>> GetAllFornecedores();
    }
}
