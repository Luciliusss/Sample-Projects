using System;

namespace switch_case_sample_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter your age (to 'exit' to quit):");
                string input = Console.ReadLine();

                int age;
                bool success = int.TryParse(input, out age);

                if (input.ToLower() == "exit")
                {
                    exit = true;
                    continue;
                }

                if (success)
                {
                    switch (age)
                    {
                        case int n when (n < 18):
                            Console.WriteLine("Child");
                            break;
                        case int n when (n >= 18 && n < 30):
                            Console.WriteLine("Youth");
                            break;
                        case int n when (n >= 30 && n <= 60):
                            Console.WriteLine("adult");
                            break;
                        case int n when (n > 60):
                            Console.WriteLine("Adult");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }
    }

}