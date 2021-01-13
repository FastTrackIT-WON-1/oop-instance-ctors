using System;

namespace InstanceCtors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Rectangle r1 = new Rectangle(new Point(10, 10), 100, 50);
            Rectangle r2 = new Rectangle(new Point(10, 10), new Point(110, 60));

            r1.Print(nameof(r1));
            r2.Print(nameof(r2));
            */

            /*
            Color color1 = Color.FromHexString("9B5C4F");
            Color color2 = Color.FromRGB(155, 92, 79);

            Console.WriteLine($"Color 1: {color1?.Hex}");
            Console.WriteLine($"Color 2: {color2?.Hex}");
            */

            ApplicationLogger.Instance.WriteLog("This is a singleton!");
        }
    }
}
