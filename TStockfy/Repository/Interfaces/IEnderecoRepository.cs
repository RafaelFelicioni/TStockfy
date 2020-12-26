using System.Collections.Generic;
using System.Threading.Tasks;
using TStockfy.Model;

namespace TStockfy.Repository.Interfaces
{
    public interface IEnderecoRepository
    {
        ValueTask<Endereco> GetById(int enderecoId);
        Task AddEndereco(Endereco endereco);
        Task UpdateEndereco(Endereco endereco, int enderecoId);
        Task RemoveEndereco(int enderecoId);
        Task<IEnumerable<Endereco>> GetAllEnderecos();
    }
}
