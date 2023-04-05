using Microsoft.EntityFrameworkCore;
using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface ITerminal
    {
        Task<IEnumerable<TerminalDTO>> GetTerminalsPerMerchant(string merchantId);
        Task<TerminalDTO> GetTerminal(string id);
        Task <string> CreateTerminal (TerminalDTO terminal, string merchantId);
        Task<IEnumerable<TerminalDTO>> GetAllTerminals();
        
    }
}
