using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            int negativeCounter = 0;

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                else if (number < 0)
                {
                    negativeCounter++;
                }
            }

            if (negativeCounter % 2 == 1)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
