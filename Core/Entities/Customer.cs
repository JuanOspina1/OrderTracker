namespace Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string MainEmail { get; set; }
    }
}