using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;
using TStockfy.Services.Queries;

namespace TStockfy.Repository
{
    public class VendaRepository : BaseRepository, IVendaRepository
    {
        private readonly ICommandText _commandText;

        public VendaRepository(IConfiguration configuration, ICommandText commandText) : base(configuration) {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Venda>> GetAllVendas() {

            return await WithConnection(async conn => {
                var query = await conn.QueryAsync<Venda>(_commandText.GetVenda);
                return query;
            });

        }

        public async ValueTask<Venda> GetById(int vendaId) {
            return await WithConnection(async conn => {
                var query = await conn.QueryFirstOrDefaultAsync<Venda>(_commandText.GetVendaById, new { VendaId = vendaId });
                return query;
            });

        }

        public async Task AddVenda(Venda venda) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.AddVenda,
                    new { TotalValor = venda.TotalValor, DataGravacao = venda.DataGravacao, RelatorioVenda = venda.RelatorioVenda, Produto = venda.Produto });
            });

        }
        public async Task UpdateVenda(Venda venda, int vendaId) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.UpdateVenda,
                    new { TotalValor = venda.TotalValor, DataGravacao = venda.DataGravacao, RelatorioVenda = venda.RelatorioVenda, Produto = venda.Produto, VendaId = vendaId });
            });

        }
        public async Task RemoveVenda(int vendaId) {

            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.RemoveVenda, new { VendaId = vendaId });
            });

        }
    }
}
