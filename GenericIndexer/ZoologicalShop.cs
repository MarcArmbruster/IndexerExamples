namespace GenericIndexer
{
    using System.Collections.Generic;
    using System.Linq;

    public class ZoologicalShop<T> : IShop<T> where T : IShopItem
    {
        private static readonly Dictionary<string, T> shopItems = new Dictionary<string, T>();

        public T this[string ian]
        {
            get => shopItems[ian];
            set => shopItems[ian] = value;
        }

        public IEnumerable<T> this[decimal price]
        {
            get => shopItems
                    .Where(i => i.Value.Price == price)
                    .Select(i => i.Value);
        }
    }
}


