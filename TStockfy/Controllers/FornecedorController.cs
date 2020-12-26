using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;

namespace TStockfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin,user")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorController(IFornecedorRepository fornecedorRepository) {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Endereco>> GetAll() {
            var fornecedores = await _fornecedorRepository.GetAllFornecedores();
            return Ok(fornecedores);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Fornecedor>> GetById(int fornecedorId) {
            var fornecedor = await _fornecedorRepository.GetById(fornecedorId);
            return Ok(fornecedor);
        }

        [HttpPost]
        public async Task<ActionResult> AddFornecedor(Fornecedor fornecedor) {
            await _fornecedorRepository.AddFornecedor(fornecedor);
            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Fornecedor>> UpdateFornecedor(Fornecedor fornecedor, int fornecedorId) {
            await _fornecedorRepository.UpdateFornecedor(fornecedor, fornecedorId);
            return Ok(fornecedor);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFornecedor(int fornecedorId) {
            await _fornecedorRepository.RemoveFornecedor(fornecedorId);
            return Ok();
        }
    }
}
