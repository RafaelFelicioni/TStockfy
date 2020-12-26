using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;
using TStockfy.Services.Queries;

namespace TStockfy.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        private readonly ICommandText _commandText;

        public ProdutoRepository(IConfiguration configuration, ICommandText commandText) : base(configuration) {
            _commandText = commandText;

        }

        public async Task<IEnumerable<Produto>> GetAllProdutos() {

            return await WithConnection(async conn => {
                var query = await conn.QueryAsync<Produto>(_commandText.GetProduto);
                return query;
            });

        }

        public async ValueTask<Produto> GetById(int produtoId) {
            return await WithConnection(async conn => {
                var query = await conn.QueryFirstOrDefaultAsync<Produto>(_commandText.GetAcessoById, new { ProdutoId = produtoId });
                return query;
            });

        }

        public async Task AddProduto(Produto produto) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.AddProduto,
                    new { NomeProduto = produto.NomeProduto, ValorProduto = produto.ValorProduto, CdgBarras = produto.CdgBarras, QntEstoque = produto.QntEstoque, LclNoEstoque = produto.LclNoEstoque, NmrNota = produto.NmrNota, Categoria = produto.Categoria });
            });

        }
        public async Task UpdateProduto(Produto produto, int produtoId) {
            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.UpdateProduto,
                    new { NomeProduto = produto.NomeProduto, ValorProduto = produto.ValorProduto, CdgBarras = produto.CdgBarras, QntEstoque = produto.QntEstoque, LclNoEstoque = produto.LclNoEstoque, NmrNota = produto.NmrNota, Categoria = produto.Categoria , ProdutoId = produtoId });
            });

        }
        public async Task RemoveProduto(int produtoId) {

            await WithConnection(async conn => {
                await conn.ExecuteAsync(_commandText.RemoveProduto, new { ProdutoId = produtoId });
            });

        }
    }
}
