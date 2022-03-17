namespace GenericIndexer
{

    public interface IShop<T>
    {
        T this[string ian] { get; set; }
    }
}
