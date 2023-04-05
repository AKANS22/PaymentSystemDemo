using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentSystem.Model
{
    public class PaymentTerminal
    {
        [Key]
        public string TerminalId { get; set; }= Guid.NewGuid().ToString();
        public string TerminalType { get; set; }
        public string  Location { get; set; }
        [ForeignKey(("MerchantId"))]
        public Merchant Merchant { get; set; }
        public ICollection <Transactions> Transactions { get; set; }
    }
}
