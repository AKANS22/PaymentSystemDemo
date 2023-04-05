using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface IMerchant
    {
        Task<IEnumerable<MerchantDTO>> GetMerchants();
        Task <MerchantDTO> GetMerchant(string id);
        Task<string> CreateMerchant(MerchantDTO merchant);
            
    }
}
