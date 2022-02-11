namespace GenericIndexer
{
    public interface IShopItem
    {
        string IAN { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
