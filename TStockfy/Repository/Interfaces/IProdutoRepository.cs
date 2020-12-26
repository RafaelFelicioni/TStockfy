using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TStockfy.Model;

namespace TStockfy.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        ValueTask<Produto> GetById(int produtoId);
        Task AddProduto(Produto produto);
        Task UpdateProduto(Produto produto, int produtoId);
        Task RemoveProduto(int produtoId);
        Task<IEnumerable<Produto>> GetAllProdutos();
    }
}
