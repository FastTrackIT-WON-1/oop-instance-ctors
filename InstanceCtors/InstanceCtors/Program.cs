using System;

namespace InstanceCtors
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(new Point(10, 10), 100, 50);
            Rectangle r2 = new Rectangle(new Point(10, 10), new Point(110, 60));

            r1.Print(nameof(r1));
            r2.Print(nameof(r2));
        }
    }
}
