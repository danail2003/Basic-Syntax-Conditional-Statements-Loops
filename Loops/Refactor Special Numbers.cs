using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int total = 0;
            
            for (int num = 1; num <= number; num++)
            {
                int digit = num;

                while (num > 0)
                {
                    total += num % 10;
                    num /= 10;
                }

                bool isTrue = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{digit} -> {isTrue}");
                total = 0;
                num = digit;
            }
        }
    }
}
