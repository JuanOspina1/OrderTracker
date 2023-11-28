namespace Core.Entities
{
    public class Item : BaseEntity
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        // public List<ItemAttribute> Attributes { get; set; }
    }
}