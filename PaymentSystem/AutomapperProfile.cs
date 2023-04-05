using AutoMapper;
using PaymentSystem.DTO;
using PaymentSystem.Model;

namespace PaymentSystem
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Merchant, MerchantDTO>().ReverseMap();
            CreateMap<PaymentTerminal, TerminalDTO>().ReverseMap();
            CreateMap<Transactions, TransactionDTO>().ReverseMap();
            C

        }
    }
}
