namespace Core.Entities
{
    public class PurchaseOrder : BaseEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public Customer Customer { get; set; }

        // A collection of items associated with this purchase order
        // public List<PurchaseOrderItem> Items { get; set; }

    }
}