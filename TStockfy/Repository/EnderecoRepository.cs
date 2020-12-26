using Dapper;
using Microsoft.Extensions.Configuration;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TStockfy.Services.Queries;

namespace TStockfy.Repository
{
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {
        private readonly ICommandText _commandText;

        public EnderecoRepository(IConfiguration configuration, ICommandText commandText) : base(configuration) {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Endereco>> GetAllEnderecos() {

            return await WithConnection(async conn => {
                var query = await conn.QueryAsync<Endereco>(_commandText.GetEndereco);
                return query;
            });

        }

        public async ValueTask<Endereco> GetById(int enderecoId) {
            return await WithConnection(async conn => {
                var query = await conn.QueryFirstOrDefaultAsync<Endereco>(_commandText.GetEnderecoById, new { EnderecoId = enderecoId });
                return query;
            });

        }

        public async Task AddEndereco(Endereco endereco) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.AddEndereco,
                    new { Logradouro = endereco.Logradouro, Bairro = endereco.Bairro, Cidade = endereco.Cidade, Estado = endereco.Estado, Cep = endereco.Cep });
            });

        }
        public async Task UpdateEndereco(Endereco endereco, int enderecoId) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.UpdateEndereco,
                    new { Logradouro = endereco.Logradouro, Bairro = endereco.Bairro, Cidade = endereco.Cidade, Estado = endereco.Estado, Cep = endereco.Cep , EnderecoId = enderecoId });
            });

        }
        public async Task RemoveEndereco(int enderecoId) {

            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.RemoveEndereco, new { EnderecoId = enderecoId });
            });

        }
    }
}