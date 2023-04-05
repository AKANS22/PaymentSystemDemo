namespace PaymentSystem.DTO
{
    public class MerchantDTO
    {
        public string MerchantId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
