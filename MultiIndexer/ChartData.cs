namespace MultiIndexer
{
    using System.Collections.Generic;
    using System.Linq;

    internal class ChartData
    {
        private readonly List<ChartPoint3D> data = new List<ChartPoint3D>();

        /// <summary>
        /// Gets the current number of data points.
        /// </summary>
        public int NumberOfPoints => this.data.Count;

        /// <summary>
        /// Gets all points with same value.
        /// </summary>
        /// <param name="pointValue">The value to search for.</param>
        /// <returns>All points with such a decimal value.</returns>
        public IEnumerable<ChartPoint3D> this[decimal pointValue]
        {
            get => data.Where(point => point.Value == pointValue);
        }

        /// <summary>
        /// 3D Indexer.
        /// </summary>
        public ChartPoint3D this[int x, int y, int z]
        {
            get
            {
                var point = data.FirstOrDefault(point => point.X == x 
                                                      && point.Y == y 
                                                      && point.Z == z);
                return point ?? ChartPoint3D.Empty;
            }
            set
            {
                var identifiedPoint = data.FirstOrDefault(point => point.X == value.X 
                                                                && point.Y == value.Y
                                                                && point.Z == value.Z);
                if (identifiedPoint == null)
                {
                    data.Add(value);
                }
                else
                {
                    identifiedPoint = value;
                }
            }
        }
    }
}