using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchant _merchant;

        public MerchantController(IMerchant merchant)
        {
            _merchant = merchant;
        }

        [HttpPost("{merchantid}/{merchant}")]

        public async Task<IActionResult> CreateMerchant(MerchantDTO merchant)
        {
            var result = await _merchant.CreateMerchant(merchant);
            return Ok(result);
        }
        [HttpGet("merchantss")]
        public async Task<IActionResult>GetMerchant(string merchantId)
        {
            var result = await _merchant.GetMerchant(merchantId); 
            return Ok(result);
        }
        [HttpGet("merchants")]
        public async Task <IActionResult>GetAllMerchants()
        {
            var result = await _merchant.GetMerchants();
            return Ok(result);
        }

        


    }
}
