using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;
using PaymentSystem.Model;
using PaymentSystem.PaymentDbContext;

namespace PaymentSystem.Repository
{
    public class MerchantRepository : IMerchant
    { private readonly PaymentSystemDbContext _dbContext;
        private readonly IMapper _mapper;
        public MerchantRepository(PaymentSystemDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<string> CreateMerchant(MerchantDTO merchant)
        {
            var merchantEntity = _mapper.Map<Merchant>(merchant);
            _dbContext.Merchants.Add(merchantEntity);
            await _dbContext.SaveChangesAsync();
            return merchantEntity.MerchantId;
        }
         
        public async Task<MerchantDTO> GetMerchant(string id)
        {
            var merchant = await _dbContext.Merchants.FindAsync(id);
            var map = _mapper.Map<MerchantDTO>(merchant);
            return map;
        }

        public async Task<IEnumerable<MerchantDTO>> GetMerchants()
        {
            var merchants = await _dbContext.Merchants.ToListAsync();
            var map = _mapper.Map<IEnumerable<MerchantDTO>>(merchants);
            return map; 
        }
    }
}
