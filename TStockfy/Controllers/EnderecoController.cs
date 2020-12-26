using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;

namespace TStockfy.Controllers
{

    [Route("api/[controller]")]
        [ApiController]
    //[Authorize(Roles = "admin,user")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoController(IEnderecoRepository enderecoRepository) {
            _enderecoRepository = enderecoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Endereco>> GetAll() {
            var enderecos = await _enderecoRepository.GetAllEnderecos();
            return Ok(enderecos);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Endereco>> GetById(int enderecoId) {
            var endereco = await _enderecoRepository.GetById(enderecoId);
            return Ok(endereco);
        }

        [HttpPost]
        public async Task<ActionResult> AddEndereco(Endereco endereco) {
            await _enderecoRepository.AddEndereco(endereco);
            return Ok(endereco);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Endereco>> UpdateEndereco(Endereco endereco, int enderecoId) {
            await _enderecoRepository.UpdateEndereco(endereco, enderecoId);
            return Ok(endereco);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEndereco(int enderecoId) {
            await _enderecoRepository.RemoveEndereco(enderecoId);
            return Ok();
        }
    }
}
