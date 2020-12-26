using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;

namespace TStockfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin,user")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository) {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Produto>> GetAll() {
            var produtos = await _produtoRepository.GetAllProdutos();
            return Ok(produtos);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Endereco>> GetById(int produtoId) {
            var produto = await _produtoRepository.GetById(produtoId);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduto(Produto produto) {
            await _produtoRepository.AddProduto(produto);
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> UpdateProduto(Produto produto, int produtoId) {
            await _produtoRepository.UpdateProduto(produto, produtoId);
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduto(int produtoId) {
            await _produtoRepository.RemoveProduto(produtoId);
            return Ok();
        }
    }
}
