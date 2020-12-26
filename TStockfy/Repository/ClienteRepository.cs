using Dapper;
using Microsoft.Extensions.Configuration;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using TStockfy.Services.Queries;
using System.Threading.Tasks;

namespace TStockfy.Repository
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        private readonly ICommandText _commandText;

        public ClienteRepository(IConfiguration configuration, ICommandText commandText) : base(configuration) {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Cliente>> GetAllClientes() {

            return await WithConnection(async conn => {
                var query = await conn.QueryAsync<Cliente>(_commandText.GetCliente);
                return query;
            });

        }

        public async ValueTask<Cliente> GetById(int clienteId) {
            return await WithConnection(async conn => {
                var query = await conn.QueryFirstOrDefaultAsync<Cliente>(_commandText.GetClienteById, new { ClienteId = clienteId });
                return query;
            });

        }

        public async Task AddCliente(Cliente cliente) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.AddCliente,
                    new { Nome = cliente.Nome, Telefone = cliente.Telefone, Email = cliente.Email, CPF = cliente.CPF, CNPJ = cliente.CNPJ, Bairro = cliente.Endereco.Bairro, Cidade = cliente.Endereco.Cidade });
            });

        }
        public async Task UpdateCliente(Cliente cliente, int clienteId) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.UpdateCliente,
                    new { Nome = cliente.Nome, Telefone = cliente.Telefone, Email = cliente.Email, CPF = cliente.CPF, CNPJ = cliente.CNPJ, Bairro = cliente.Endereco.Bairro , ClienteId = clienteId });
            });

        }
        public async Task RemoveCliente(int clienteId) {

            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.RemoveCliente, new { ClienteId = clienteId });
            });

        }
    }
}