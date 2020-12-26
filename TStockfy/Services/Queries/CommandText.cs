using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TStockfy.Model;

namespace TStockfy.Services.Queries
{
    public class CommandText : ICommandText
    {
        public string GetAcesso => "Select * from Acesso";
        public string GetAcessoById => "Select * from Acesso where AcessoId = @AcessoId";
        public string AddAcesso => "Insert into  [TStockfy].[dbo].[Acesso] ([Nome], Senha) values (@Nome, @Senha)";
        public string UpdateAcesso => "Update [TStocfy].[dbo].[Acesso] set Nome = @Nome, Senha = @Senha where AcessoId = @AcessoId";
        public string RemoveAcesso => "Delete from [TStockfy].[dbo].[Acesso] where AcessoId= @AcessoId";
        //public string GetProductByIdSp => "GetProductId";

        public string GetCliente => "Select * From Cliente";
        public string GetClienteById => "Select * from Cliente where ClienteId = @ClienteId";
        public string AddCliente => "Insert into  [TStockfy].[dbo].[Cliente] ([Nome], Telefone, Email, CPF, CNPJ, Endereco) values (@Nome, @Telefone, @Email, @CPF, @CNPJ, @Endereco)";
        public string UpdateCliente => "Update [TStocfy].[dbo].[Cliente] set Nome = @Nome, Telefone = @Telefone, Email = @Email, CPF = @CPF, CNPJ = @CNPJ, Endereco = @Endereco where ClienteId = @ClienteId";
        public string RemoveCliente => "Delete from [TStockfy].[dbo].[Cliente] where ClienteId = @ClienteId";

        public string GetEndereco => "Select * from Endereco";
        public string GetEnderecoById => "Select * from Endereco where EnderecoId = @EnderecoId";
        public string AddEndereco => "Insert into  [TStockfy].[dbo].[Endereco] ([Logradouro], Bairro, Cidade, Estado, CEP) values (@Logradouro, @Bairro, @Cidade, @Estado, @CEP)";
        public string UpdateEndereco => "Update [TStocfy].[dbo].[Endereco] set Logradouro = @Logradouro, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, CEP = @CEP where EnderecoId = @EnderecoId";
        public string RemoveEndereco => "Delete from [TStockfy].[dbo].[Endereco] where EnderecoId = @EnderecoId";

        public string GetFornecedor => "Select * from Fornecedor";
        public string GetFornecedorById => "Select * from Fornecedor where FornecedorId = @FornecedorId";
        public string AddFornecedor => "Insert into  [TStockfy].[dbo].[Fornecedor] ([NomeEmpresa], CNPJ,  Endereco, Telefone, Email) values (@NomeEmpresa, @CNPJ, @Endereco, @Telefone, @Email)";
        public string UpdateFornecedor => "Update [TStocfy].[dbo].[Fornecedor] set NomeEmpresa = @NomeEmpresa, CNPJ = @CNPJ, Endereco = @Endereco, Telefone = @Telefone, Email = @Email where FornecedorId = @FornecedorId";
        public string RemoveFornecedor => "Delete from [TStockfy].[dbo].[Fornecedor] where FornecedorId = @FornecedorId";

        public string GetProduto => "Select * from Produto";
        public string GetProdutoById => "Select * from Produto where ProdutoId = @ProdutoId";
        public string AddProduto => "Insert into  [TStockfy].[dbo].[Produto] ([NomeProduto], ValorProduto, CdgBarras, QntEstoque, LclNoEstoque, NmrNota, Categoria) values (@NomeProduto, @ValorProduto, @CdgBarras, @QntEstoque, @LclNoEstoque, @NmrNota, @Categoria)";
        public string UpdateProduto => "Update [TStocfy].[dbo].[Produto] set NomeProduto = @NomeProduto, ValorProduto = @ValorProduto, CdgBarras = @CdgBarras, QntEstoque = @QntEstoque, LclNoEstoque = @LclEstoque, NmrNota = @NmrNota, Categoria = @Categoria where ProdutoId = @ProdutoId";
        public string RemoveProduto => "Delete from [TStockfy].[dbo].[Produto] where ProdutoId = @ProdutoId";

        public string GetVenda => "Select * from Venda";
        public string GetVendaById => "Select * from Venda where VendaId = @VendaId";
        public string AddVenda => "Insert into  [TStockfy].[dbo].[Venda] ([TotalValor], DataGravacao, RelatorioVenda, Produto ) values (@TotalValor, @DataGravacao, @RelatorioVenda, @Produto)";
        public string UpdateVenda => "Update [TStocfy].[dbo].[Venda] set TotalValor = @TotalValor, DataGravacao = GETDATE(), RelatorioVenda = @RelatorioVenda, Produto = @Produt where VendaId = @VendaId";
        public string RemoveVenda => "Delete from [TStockfy].[dbo].[Venda] where VendaId= @VendaId";
    }
}
