namespace SingleIndexer
{
    using System;
    using System.Collections.Generic;

    internal class Store
    {
        private static readonly Dictionary<Guid, IProduct> listedStoreItems = new Dictionary<Guid, IProduct>();
        public IProduct this[Guid productId]
        {
            get
            {
                if (!listedStoreItems.ContainsKey(productId))
                {
                    throw new ProductNotFoundException($"No product with ID {productId} available");
                }

                return listedStoreItems[productId];
            }

            set
            {
                listedStoreItems[productId] = value;
            }
        }
    }

    /// <summary>
    /// alternative: generic indexer
    /// </summary>
    internal class Store<T>
    {
        private static readonly Dictionary<Guid, T> listedStoreItems = new Dictionary<Guid, T>();

        public T this[Guid storeItemId] 
        {
            get
            {
                if (!listedStoreItems.ContainsKey(storeItemId))
                {
                    throw new ProductNotFoundException($"No store item with ID {storeItemId} available");
                }

                return listedStoreItems[storeItemId];
            }

            set
            {
                listedStoreItems[storeItemId] = value;
            }
        }
    }
}
