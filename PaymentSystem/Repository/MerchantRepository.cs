using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;

namespace PaymentSystem.Repository
{
    public class MerchantRepository : IMerchant
    {
        public Task<int> CreteMerchant(MerchantDTO marchant)
        {
            throw new NotImplementedException();
        }

        public Task<MerchantDTO> GetMarchant(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MerchantDTO>> GetMErchants()
        {
            throw new NotImplementedException();
        }
    }
}
