using System;

namespace Car_Number
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber ; j++)
                {
                    for (int k = firstNumber; k <= secondNumber; k++)
                    {
                        for (int l = firstNumber; l <= secondNumber; l++)
                        {
                            if(i % 2 == 0 && l % 2 != 0)
                            {
                                if (i > l && (j + k) % 2 == 0)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                            else if (i % 2 != 0 && l % 2 == 0)
                            {
                                if (i > l && (j + k) % 2 == 0)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
