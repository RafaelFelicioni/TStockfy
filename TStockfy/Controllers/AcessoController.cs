using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;

namespace TStockfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin,user")]
    public class AcessoController : ControllerBase
    {
        private readonly IAcessoRepository _acessoRepository;

        public AcessoController(IAcessoRepository acessoRepository) {
            _acessoRepository = acessoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Acesso>> GetAll() {
            var acessos = await _acessoRepository.GetAllAcessos();
            return Ok(acessos);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Acesso>> GetById(int acessoId) {
            var acesso = await _acessoRepository.GetById(acessoId);
            return Ok(acesso);
        }

        [HttpPost]
        public async Task<ActionResult> AddAcesso(Acesso acesso) {
            await _acessoRepository.AddAcesso(acesso);
            return Ok(acesso);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Acesso>> UpdateAcesso(Acesso acesso, int acessoId) {
            await _acessoRepository.UpdateAcesso(acesso, acessoId);
            return Ok(acesso);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAcesso(int acessoId) {
            await _acessoRepository.RemoveAcesso(acessoId);
            return Ok();
        }
    }
}
