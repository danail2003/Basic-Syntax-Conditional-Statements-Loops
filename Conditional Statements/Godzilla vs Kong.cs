using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double pricePerStat = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;

            if (statists > 150)
            {
                pricePerStat = pricePerStat - (pricePerStat * 0.10);
            }

            double priceOfClothes = statists * pricePerStat;
            double totalSum = decor + priceOfClothes;

            if (budget <= priceOfClothes)
            {
                double needMoney =Math.Abs(budget - totalSum);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }

            else
            {
                double leftMoney = budget - totalSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
        }
    }
}
