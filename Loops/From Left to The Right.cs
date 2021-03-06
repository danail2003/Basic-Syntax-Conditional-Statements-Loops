using System;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());           

            for (int i = 0; i < lines; i++)
            {
                string numbers = Console.ReadLine();
                string[] arrNumbers = numbers.Split();
                
                long firstNumber = long.Parse(arrNumbers[0]);
                long secondNumber = long.Parse(arrNumbers[1]);               
                long sumFirst = 0;
                long sumSecond = 0;

                if (firstNumber > secondNumber)
                {
                    while (firstNumber != 0)
                    {
                        long digit = firstNumber % 10;
                        sumFirst += digit;
                        firstNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(sumFirst));
                }
                else
                {
                    while (secondNumber != 0)
                    {
                        long digit = secondNumber % 10;
                        sumSecond += digit;
                        secondNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(sumSecond));
                }
            }
        }
    }
}
