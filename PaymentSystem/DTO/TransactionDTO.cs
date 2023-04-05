namespace PaymentSystem.DTO
{
    public class TransactionDTO
    {
        public int TranId { get; set; }
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
        public string TerminalId { get; set; }
    }
}
