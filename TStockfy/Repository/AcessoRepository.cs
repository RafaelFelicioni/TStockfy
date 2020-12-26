using Dapper;
using Microsoft.Extensions.Configuration;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using TStockfy.Services.Queries;

namespace TStockfy.Repository
{
    public class AcessoRepository : BaseRepository, IAcessoRepository
    {
        private readonly ICommandText _commandText;

        public AcessoRepository(IConfiguration configuration, ICommandText commandText) : base(configuration) {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Acesso>> GetAllAcessos() {

            return await WithConnection(async conn => {
                var query = await conn.QueryAsync<Acesso>(_commandText.GetAcesso);
                return query;
            });

        }

        public async ValueTask<Acesso> GetById(int acessoId) {
            return await WithConnection(async conn => {
                var query = await conn.QueryFirstOrDefaultAsync<Acesso>(_commandText.GetAcessoById, new { AcessoId = acessoId });
                return query;
            });

        }

        public async Task AddAcesso(Acesso acesso) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.AddAcesso,
                    new { Nome = acesso.Nome, Senha = acesso.Senha });
            });

        }
        public async Task UpdateAcesso(Acesso acesso, int acessoId) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.UpdateAcesso,
                    new { Nome = acesso.Nome, Senha = acesso.Senha, AcessoId = acessoId });
            });

        }
        public async Task RemoveAcesso(int acessoId) {

            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.RemoveAcesso, new { AcessoId = acessoId });
            });

        }
    }
}
