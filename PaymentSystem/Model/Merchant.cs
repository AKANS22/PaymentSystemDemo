using System.ComponentModel.DataAnnotations;

namespace PaymentSystem.Model
{
    public class Merchant
    {
        [Key]
        public int MerchantId { get; set; }
        public string Name { get; set;}
        public string Address { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}
        public List <PaymentTerminal> Terminals { get; set;}
    }
}
