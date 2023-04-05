using System.ComponentModel.DataAnnotations;

namespace PaymentSystem.Model
{
    public class Merchant
    {
        [Key]
        public string MerchantId { get; set; }=Guid.NewGuid().ToString();
        public string Name { get; set;}
        public string Address { get; set;}
        public string Email { get; set;}
        public string Phone { get; set;}
        public ICollection <PaymentTerminal> Terminals { get; set;}
    }
}
