using AutoMapper;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;
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
        public async Task<int> CreateMerchant(<MerchantDTO> marchant)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateMerchant(MerchantDTO marchant)
        {
            throw new NotImplementedException();
        }

        public Task<MerchantDTO> GetMerchant(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MerchantDTO>> GetMerchants()
        {
            throw new NotImplementedException();
        }
    }
}
