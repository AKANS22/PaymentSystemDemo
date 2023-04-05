using PaymentSystem.DTO;

namespace PaymentSystem.Abstract.Interface
{
    public interface ITerminalServices
    {
        Task<IEnumerable<TerminalDTO>> GetTerminals();
        Task<TerminalDTO> GetTerminal(int id);
        Task<int> CreateTerminal(TerminalDTO terminal);
    }
}
