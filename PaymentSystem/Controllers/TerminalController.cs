using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly ITerminal _terminal;

        public TerminalController(ITerminal terminal)
        {
            _terminal = terminal;
        }

        [HttpPost("terminal")]

        public async Task<IActionResult> CreateTerminal(TerminalDTO terminal, string merchantId)
        {
            var result = await _terminal.CreateTerminal(terminal, merchantId);
            return Ok(result);
        }
        [HttpGet("terminal")]
        public async Task<IActionResult> GetTerminalsPerMerchant(string merchantId)
        {
            var result = await _terminal.GetTerminalsPerMerchant(merchantId);
            return Ok(result);
        }
        [HttpGet("terminals")]
        public async Task<IActionResult> GetAllterminalss()
        {
            var result = await _terminal.GetAllTerminals();
            return Ok(result);
        }

    }
}
