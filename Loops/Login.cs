using System;

namespace Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string pass = "";
            
            for(int i = username.Length - 1; i >= 0; i--)
            {
                char symbol = username[i];
                pass += symbol;
            }

            for (int i = 0; i < 4; i++)
            {
                string password = Console.ReadLine();

                if (password == pass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if(password != pass && i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if(password != pass && i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }
        }
    }
}
