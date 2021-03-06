using System;

namespace Giftbox_Coverage
{
    class Program
    {
        static void Main()
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int numberOfSheets = int.Parse(Console.ReadLine());
            double areaOfSheet = double.Parse(Console.ReadLine());

            double area = Math.Pow(sizeOfSide, 2) * 6;
            double smallCovering = numberOfSheets / 3;
            double normalCovering = numberOfSheets - smallCovering;
            double allCover = (normalCovering * areaOfSheet) + (areaOfSheet * 0.25) * smallCovering;
            double diff = allCover / area * 100;
            
            Console.WriteLine($"You can cover {diff:f2}% of the box.");
        }
    }
}
