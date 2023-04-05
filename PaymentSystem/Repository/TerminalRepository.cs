using PaymentSystem.Abstract.Interface;
using PaymentSystem.DTO;

namespace PaymentSystem.Repository
{
    public class TerminalRepository : ITerminal
    {
        public Task<int> CreateTerminal(TerminalDTO terminal)
        {
            throw new NotImplementedException();
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
