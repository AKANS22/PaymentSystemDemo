using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface ITransaction
    {
        Task<IEnumerable<TransactionDTO>> GetTransactions();
        Task<IEnumerable<TransactionDTO>> GetTransactionPerTerminal(string merchantId, string terminalId);
        Task <string> CreateTransaction(TransactionDTO transaction, string merchantId);
    }
}
