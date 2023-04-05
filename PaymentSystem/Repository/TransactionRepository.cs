using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;

namespace PaymentSystem.Repository
{
    public class TransactionRepository : ITransaction
    {
        public Task<int> CreateTransaction(TransactionDTO transaction)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionDTO> GetTransaction(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
