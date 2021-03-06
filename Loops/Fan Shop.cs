using System;

namespace Fan_Shop
{
    class Program
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            
            int price = 0;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                string subject = Console.ReadLine();

                if (subject == "hoodie")
                {
                    price = 30;
                }
                else if (subject == "keychain")
                {
                    price = 4;
                }
                else if (subject == "T-shirt")
                {
                    price = 20;
                }
                else if (subject == "flag")
                {
                    price = 15;
                }
                else if (subject == "sticker")
                {
                    price = 1;
                }

                sum += price;
            }

            int diff = Math.Abs(budget - sum);
            if (budget >= sum)
            {
                Console.WriteLine($"You bought {count} items and left with {diff} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diff} more lv.");
            }
        }
    }
}
