using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;

namespace TStockfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin,user")]
    public class VendaController : ControllerBase
    {
        private readonly  IVendaRepository _vendaRepository;

        public VendaController(IVendaRepository vendaRepository) {
            _vendaRepository = vendaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Venda>> GetAll() {
            var vendas = await _vendaRepository.GetAllVendas();
            return Ok(vendas);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Venda>> GetById(int vendaId) {
            var venda = await _vendaRepository.GetById(vendaId);
            return Ok(venda);
        }

        [HttpPost]
        public async Task<ActionResult> AddVenda(Venda venda) {
            await _vendaRepository.AddVenda(venda);
            return Ok(venda);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Venda>> UpdateVenda(Venda venda, int vendaId) {
            await _vendaRepository.UpdateVenda(venda, vendaId);
            return Ok(venda);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVenda(int vendaId) {
            await _vendaRepository.RemoveVenda(vendaId);
            return Ok();
        }
    }
}
