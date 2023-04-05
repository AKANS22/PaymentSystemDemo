using Microsoft.EntityFrameworkCore;
using PaymentSystem.Model;

namespace PaymentSystem.PaymentDbContext
{
    public class PaymentSystemDbContext: DbContext
    {
        public PaymentSystemDbContext(DbContextOptions <PaymentSystemDbContext> options) :base (options)
        {
            

        }

        public DbSet<Merchant> Merchants { get; set; }
        public DbSet <PaymentTerminal> Terminal { get; set; }
        public DbSet <Transactions> Transactions{ get; set; }
    }
}
