namespace SingleIndexer
{
    public interface IProduct
    {
        Guid ProductId { get; set; }    
        decimal Price { get; set; } 
        string Name { get; set; }   
        string Description { get; set; }
    }
}