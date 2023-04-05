using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface IMerchant
    {
        Task<IEnumerable<MerchantDTO>> GetMErchants();
        Task <MerchantDTO> GetMarchant(int id);
        Task<int> CreteMerchant(MerchantDTO marchant);
            
    }
}
