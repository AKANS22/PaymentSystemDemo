namespace PaymentSystem.Model
{
    public class Transactions
    {
        public int TranId { get; set; }
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
        public string TerminalId { get; set; }

        public PaymentTerminal Terminal {get; set } 
    }
}
