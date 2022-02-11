namespace SingleIndexer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Store<T>
    {
        private static Dictionary<Guid, IProduct> listedStoreItems = new Dictionary<Guid, IProduct>();

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

        // alternative: generic indexer
         
        public T this[Guid productId] 
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
        */
    }
}
