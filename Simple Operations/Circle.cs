using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            
            double area = Math.PI * radius * radius;
            double perimeters = 2 * Math.PI * radius;
            
            Console.WriteLine($"{ area:f2}");
            Console.WriteLine($"{ perimeters:f2}");
        }
    }
}
