using System;

namespace Coins
{
    class Program
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            
            int coins = 0;
            decimal total = Math.Floor(money * 100);

            while (total != 0)
            {
                if (total >= 200)
                {
                    total -= 200;
                    coins++;
                }
                else if (total >= 100)
                {
                    total -= 100;
                    coins++;
                }
                else if (total >= 50)
                {
                    total -= 50;
                    coins++;
                }
                else if (total >= 20)
                {
                    total -= 20;
                    coins++;
                }
                else if (total >= 10)
                {
                    total -= 10;
                    coins++;
                }
                else if (total >= 5)
                {
                    total -= 5;
                    coins++;
                }
                else if (total >= 2)
                {
                    total -= 2;
                    coins++;
                }
                else if (total == 1)
                {
                    total -= 1;
                    coins++;
                }
            }

            Console.WriteLine(coins);
        }
    }
}
