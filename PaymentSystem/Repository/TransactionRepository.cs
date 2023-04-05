using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;
using PaymentSystem.Model;
using PaymentSystem.PaymentDbContext;

namespace PaymentSystem.Repository
{
    public class TransactionRepository : ITransaction
    {
        public readonly PaymentSystemDbContext _context;
        public readonly IMapper _mapper;

        public TransactionRepository(PaymentSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> CreateTransaction(TransactionDTO transaction)
        {

            var trasanctionEntity = _mapper.Map<Transactions>(transaction);
            _context.Transactions.Add(trasanctionEntity);
            await _context.SaveChangesAsync();
            return trasanctionEntity.TranId;
        }

        public async Task<TransactionDTO> GetTransaction(int Id)
        {
            var transaction = await _context.Transactions.FindAsync(Id);
            return _mapper.Map<TransactionDTO>(transaction);
        }

        public async Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            var transaction = await _context.Transactions.ToListAsync();
            return _mapper.Map<IEnumerable<TransactionDTO>>(transaction);
        }
    }
}
