using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;
using PaymentSystem.Model;
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
        public async Task<string> CreateTerminal(TerminalDTO terminal, string merchantId)
        {
            var currentMerchant = _context.Merchants.FirstOrDefault(x => x.MerchantId == merchantId);
            if (currentMerchant == null) 
            {
                return "Invalid User Credentials";
            }
            var TerminalEntity = _mapper.Map<PaymentTerminal>(terminal);
            TerminalEntity.Merchant = currentMerchant;
            _context.Terminal.Add(TerminalEntity);
            await _context.SaveChangesAsync();
            return TerminalEntity.TerminalId;
        }

        public async Task<TerminalDTO> GetTerminal(string id)
        {
            var terminal = await _context.Terminal.FindAsync(id);
            return _mapper.Map<TerminalDTO>(terminal);
        }

        public async Task<IEnumerable<TerminalDTO>> GetTerminalsPerMerchant(string merchantId)
        {
            
            var terminal = await _context.Terminal.Where(x=> x.Merchant.MerchantId == merchantId).ToListAsync();
            var map = _mapper.Map<IEnumerable<TerminalDTO>>(terminal);
            return map;
        }

        public async Task<IEnumerable<TerminalDTO>>GetAllTerminals()
        {
            var terminal = await _context.Terminal.ToListAsync();
            var map =_mapper.Map<IEnumerable<TerminalDTO>>(terminal);
            return map; 
        }
    
    }
}
