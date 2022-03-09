namespace SingleIndexer
{
    using System;

    public class Program
    {
        private static Guid guid = Guid.NewGuid();
        private static Store<IProduct> store = new Store<IProduct>();

        public static void Main(string[] args)
        {
            IProduct product = new Product
            {
                ProductId = guid
            };

            store[guid] = product;
        }

        private static IProduct GetProduct(Guid productIdentifier)
        {
            var product = store[productIdentifier];
            return product;
        }
    }
}
