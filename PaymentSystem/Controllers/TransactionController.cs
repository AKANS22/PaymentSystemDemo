using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransaction _transaction;

        public TransactionController(ITransaction transaction)
        {
  
            _transaction = transaction;
        }

        [HttpPost("transaction")]

        public async Task<IActionResult> CreateTransaction(TransactionDTO transaction, string merchantId)
        {
            var result = await _transaction.CreateTransaction(transaction, merchantId);
            return Ok(result);
        }
        [HttpGet("trasanction")]
        public async Task<IActionResult> GetTransactionPerTerminal(string transactionId, string terminalId)
        {
            var result = await _transaction.GetTransactionPerTerminal(transactionId, terminalId);
            return Ok(result);
        }
        [HttpGet("transactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            var result = await _transaction.GetTransactions();
            return Ok(result);
        }

    }
}
