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
        public async Task<string> CreateTransaction(TransactionDTO transaction, string merchantId)
        {
            var merchantTerminal = await _context.Terminal.FirstOrDefaultAsync(x=> x.Merchant.MerchantId == merchantId);

            if (merchantTerminal == null) 
            {
                return "Invalid credentials";
            
            }
            var trasanctionEntity = _mapper.Map<Transactions>(transaction);
            trasanctionEntity.Terminal = merchantTerminal;
            _context.Transactions.Add(trasanctionEntity);
            await _context.SaveChangesAsync();
            return trasanctionEntity.TranId;
        }

        public async Task<IEnumerable<TransactionDTO>> GetTransactionPerTerminal(string merchantId, string terminalId)
        {
            
            var transaction = await _context.Transactions.Where(x=>x.Terminal.Merchant.MerchantId==merchantId && x.Terminal.TerminalId==terminalId).ToListAsync();
            var map =_mapper.Map<IEnumerable<TransactionDTO>>(transaction);
            return map;
        }

        public async Task<IEnumerable<TransactionDTO>> GetTransactions()
        {
            var transaction = await _context.Transactions.ToListAsync();
            return _mapper.Map<IEnumerable<TransactionDTO>>(transaction);
        }
    }
}
