namespace SingleIndexer
{
    internal class Product : IProduct
    {
        public Guid ProductId { get; set; }
        public decimal Price { get; set; } = 0m;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
