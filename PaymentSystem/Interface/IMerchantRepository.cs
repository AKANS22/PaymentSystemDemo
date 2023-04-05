using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface IMerchant
    {
        Task<IEnumerable<MerchantDTO>> GetMerchants();
        Task <MerchantDTO> GetMerchant(int id);
        Task<int> CreateMerchant(MerchantDTO merchant);
            
    }
}
