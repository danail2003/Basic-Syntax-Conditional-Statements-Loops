using System;

namespace Max_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            int biggestNumber = int.MinValue;

            while (counter < number)
            {
                int number2 = int.Parse(Console.ReadLine());

                if (number2 > biggestNumber)
                {
                    biggestNumber = number2;
                }

                counter++;
            }

            Console.WriteLine(biggestNumber);
        }
    }
}
