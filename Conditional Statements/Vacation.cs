using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            
            double price = 0;

            if (day == "Friday")
            {
                if (typeOfPeople == "Students")
                {
                    price = countOfPeople * 8.45;
                    if (countOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfPeople == "Business")
                {
                    price = countOfPeople * 10.90;
                    if (countOfPeople >= 100)
                    {
                        price = (countOfPeople - 10) * 10.90;
                    }
                }
                else if (typeOfPeople == "Regular")
                {
                    price = countOfPeople * 15;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price *= 0.95;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfPeople == "Students")
                {
                    price = countOfPeople * 9.80;
                    if (countOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfPeople == "Business")
                {
                    price = countOfPeople * 15.60;
                    if (countOfPeople >= 100)
                    {
                        price = (countOfPeople - 10) * 15.60;
                    }
                }
                else if (typeOfPeople == "Regular")
                {
                    price = countOfPeople * 20;
                    if(countOfPeople>=10 && countOfPeople <= 20)
                    {
                        price *= 0.95;
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfPeople == "Students")
                {
                    price = countOfPeople * 10.46;
                    if (countOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfPeople == "Business")
                {
                    price = countOfPeople * 16;
                    if (countOfPeople >= 100)
                    {
                        price = (countOfPeople - 10) * 16;
                    }
                }
                else if (typeOfPeople == "Regular")
                {
                    price = countOfPeople * 22.50;
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price *= 0.95;
                    }
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
