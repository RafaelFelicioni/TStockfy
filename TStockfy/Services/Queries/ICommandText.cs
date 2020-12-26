using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TStockfy.Services.Queries
{
    public interface ICommandText
    {
        string GetAcesso { get; }
        string GetAcessoById { get; }
        string AddAcesso { get; }
        string UpdateAcesso { get; }
        string RemoveAcesso { get; }
        //string GetProductByIdSp { get; }

        string GetCliente { get; }
        string GetClienteById { get; }
        string AddCliente { get; }
        string UpdateCliente { get; }
        string RemoveCliente { get; }

        string GetEndereco { get; }
        string GetEnderecoById { get; }
        string AddEndereco { get; }
        string UpdateEndereco { get; }
        string RemoveEndereco { get; }

        string GetFornecedor { get; }
        string GetFornecedorById { get; }
        string AddFornecedor { get; }
        string UpdateFornecedor { get; }
        string RemoveFornecedor { get; }

        string GetProduto { get; }
        string GetProdutoById { get; }
        string AddProduto { get; }
        string UpdateProduto { get; }
        string RemoveProduto { get; }

        string GetVenda { get; }
        string GetVendaById { get; }
        string AddVenda { get; }
        string UpdateVenda { get; }
        string RemoveVenda { get; }
    }
}
