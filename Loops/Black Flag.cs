using System;

namespace Black_Flag
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            
            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.50;
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.70;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / expectedPlunder * 100;
                
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
