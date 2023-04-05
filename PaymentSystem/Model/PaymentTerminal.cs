namespace PaymentSystem.Model
{
    public class PaymentTerminal
    {
        public int TerminalId { get; set; }
        public string TerminalType { get; set; }
        public string  Location { get; set; }
        public Merchant Merchant { get; set; }
        public List <Transactions> Transactions { get; set; }
    }
}
