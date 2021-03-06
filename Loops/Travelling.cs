using System;

namespace Travelling
{
    class Program
    {
        static void Main()
        {
            string destination = Console.ReadLine();
            
            double allMoney = 0.0;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                
                while (allMoney < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    allMoney += money;
                }

                if (allMoney >= budget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    allMoney = 0.0;
                }

                destination = Console.ReadLine();
                
                if (destination == "End")
                {
                    break;
                }
            }
        }
    }
}
