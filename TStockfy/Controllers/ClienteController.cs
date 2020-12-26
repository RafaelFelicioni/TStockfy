using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TStockfy.Model;
using TStockfy.Repository.Interfaces;

namespace TStockfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin,user")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository) {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Cliente>> GetAll() {
            var clientes = await _clienteRepository.GetAllClientes();
            return Ok(clientes);
        }


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Cliente>> GetById(int clienteId) {
            var cliente = await _clienteRepository.GetById(clienteId);
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult> AddCliente(Cliente cliente) {
            await _clienteRepository.AddCliente(cliente);
            return Ok(cliente);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Cliente>> UpdateCliente(Cliente cliente, int clienteId) {
            await _clienteRepository.UpdateCliente(cliente, clienteId);
            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCliente(int clienteId) {
            await _clienteRepository.RemoveCliente(clienteId);
            return Ok();
        }
    }
}
