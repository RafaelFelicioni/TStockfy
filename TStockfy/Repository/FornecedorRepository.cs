using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;
using TStockfy.Services.Queries;

namespace TStockfy.Repository
{
    public class FornecedorRepository : BaseRepository, IFornecedorRepository
    {
        private readonly ICommandText _commandText;

        public FornecedorRepository(IConfiguration configuration, ICommandText commandText) : base(configuration) {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Fornecedor>> GetAllFornecedores() {

            return await WithConnection(async conn => {
                var query = await conn.QueryAsync<Fornecedor>(_commandText.GetFornecedor);
                return query;
            });

        }

        public async ValueTask<Fornecedor> GetById(int fornecedorId) {
            return await WithConnection(async conn => {
                var query = await conn.QueryFirstOrDefaultAsync<Fornecedor>(_commandText.GetFornecedorById, new { FornecedorId = fornecedorId });
                return query;
            });

        }

        public async Task AddFornecedor(Fornecedor fornecedor) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.AddFornecedor,
                    new { NomeEmpresa = fornecedor.NomeEmpresa, CNPJ = fornecedor.CNPJ, Endereco = fornecedor.Endereco, Telefone = fornecedor.Telefone, Email = fornecedor.Email });
            });

        }
        public async Task UpdateFornecedor(Fornecedor fornecedor, int fornecedorId) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.UpdateFornecedor,
                    new { NomeEmpresa = fornecedor.NomeEmpresa, CNPJ = fornecedor.CNPJ, Endereco = fornecedor.Endereco, Telefone = fornecedor.Telefone, Email = fornecedor.Email , FornecedorId = fornecedorId });
            });

        }
        public async Task RemoveFornecedor(int fornecedorId) {

            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.RemoveFornecedor, new { FornecedorId = fornecedorId });
            });

        }
    }
}
