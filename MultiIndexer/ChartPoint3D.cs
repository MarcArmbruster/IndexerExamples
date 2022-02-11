namespace MultiIndexer
{
    internal class ChartPoint3D
    {
        public int X { get; set; } = int.MinValue;

        public int Y { get; set; } = int.MinValue;

        public int Z { get; set; } = int.MinValue;

        public decimal? Value { get; set; }

        public string HexColor { get; set; } = string.Empty;

        public static ChartPoint3D Empty { get; } = new ChartPoint3D();
    }
}
