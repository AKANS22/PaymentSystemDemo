using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface ITransactionServices
    {
        Task<IEnumerable<TransactionDTO>> GetTransactions();
        Task<TransactionDTO> GetTransaction(int Id);
        Task<int> CreateTransaction(TransactionDTO transaction);
    }
}
