using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (char i = (char)firstNumber; i <= secondNumber; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
