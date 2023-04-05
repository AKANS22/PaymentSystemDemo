using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentSystem.Model
{
    public class Transactions
    {
        [Key]
        public string TranId { get; set; } = Guid.NewGuid().ToString();
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
     
        [ForeignKey(("TerminalId"))]
        public PaymentTerminal Terminal { get; set; } 
    }
}
