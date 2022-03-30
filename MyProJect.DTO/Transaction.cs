namespace MyProJect.DTO
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid ManagerID { get; set; }
        public Manager Manager { get; set; }
        public decimal TotalPrice { get; set; }

    }
}