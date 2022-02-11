namespace GenericIndexer
{
    internal class Snake : IShopItem
    {
        public string IAN { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0m;
        public bool IsPoisonous { get; set; } = true;
    }
}
