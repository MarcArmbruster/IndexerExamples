namespace IndexerNames
{
    using System.Collections.Generic;

    public class Container
    {
        private Dictionary<int, string> data = new Dictionary<int, string>();

        public string? Item { get; set; }

        [System.Runtime.CompilerServices.IndexerName("MyIndexer")]
        public string this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }
    }
}
