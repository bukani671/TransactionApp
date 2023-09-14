namespace TransactionApp.Models
{
    public class Transaction:BaseEntity
    {
        public Decimal Amount { get; set; }
        public Decimal Balance { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
