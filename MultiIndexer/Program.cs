namespace MultiIndexer
{
    public class Program
    {
        private static ChartData chartData = new ChartData();

        public static void Main(string[] args)
        {
            InitData();
            ApplyValue(8, 2, 333, 99m);
            IsEqual(8, 2, 333, 99m);
            CountOfEqualValues(3m);            


            // bereits in 1.x vorhanden
            // mehrdimensonal
            // instance member -> nict statisch!
            // get/set -> set mit impliziten value Parameter
            // können überladen werden (durch index item type -> z.B. string und int)
            // können auch als Generic verwendet werden
            // können in Interfaces definiert werden (vgl. IDataErrorInfo) -> beachte Mehrdeutigkeiten
            // performance
            // flexibler als Arrays -> complexe objekte = ChartData.cs
            // binding möglich
            // einfach zu lesen
        }

        private static bool IsEqual(int x, int y, int z, decimal value)
        {
            return chartData[x, y, z].Value == value;
        }

        private static void ApplyValue(int x, int y, int z, decimal value)
        {
            chartData[x, y, z].Value = value;
        }

        private static void InitData()
        {
            chartData[0, 1, 111] = new ChartPoint3D { X = 0, Y = 1, Value = 11m, HexColor = "#000000" };
            chartData[5, 7, 222] = new ChartPoint3D { X = 5, Y = 7, Value = 22m, HexColor = "#FAEBD7" };
            chartData[8, 2, 333] = new ChartPoint3D { X = 8, Y = 8, Value = 33m, HexColor = "#DC143C" };
        }

        private static int CountOfEqualValues(decimal value)
        {
            var count = chartData[value].Count();
            return count;
        }
    }
}