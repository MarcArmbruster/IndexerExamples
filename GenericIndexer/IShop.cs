namespace GenericIndexer
{

    internal interface IShop<T>
    {
        T this[string ian] { get; set; }
    }
}
