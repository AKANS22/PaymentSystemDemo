using AutoMapper;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;
using PaymentSystem.PaymentDbContext;

namespace PaymentSystem.Repository
{
    public class TerminalRepository : ITerminal
    {
        public readonly PaymentSystemDbContext _context;
        public readonly IMapper _mapper;

        public TerminalRepository( PaymentSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<int> CreateTerminal(TerminalDTO terminal)
        {
            
        }

        public Task<TerminalDTO> GetTerminal(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TerminalDTO>> GetTerminals()
        {
            throw new NotImplementedException();
        }
    }
}
