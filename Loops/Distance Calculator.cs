using System;

namespace Distance_Calculator
{
    class Program
    {
        static void Main()
        {
            int steps = int.Parse(Console.ReadLine());
            double lengthOfStep = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            
            double travelDistance = 0;

            for (int i = 1; i <= steps; i++)
            {
                if (i % 5 == 0)
                {
                    travelDistance += lengthOfStep * 0.7;
                }
                else
                {
                    travelDistance += lengthOfStep;
                }
            }

            double percentage = travelDistance / distance;

            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
