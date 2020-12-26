using TStockfy.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TStockfy.Repository.Interfaces
{
    public interface IClienteRepository
    {
        ValueTask<Cliente> GetById(int clienteId);
        Task AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente, int clienteId);
        Task RemoveCliente(int clienteId);
        Task<IEnumerable<Cliente>> GetAllClientes();
    }
}
