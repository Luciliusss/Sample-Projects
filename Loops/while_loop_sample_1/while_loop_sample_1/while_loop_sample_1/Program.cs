using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

namespace while_loop_sample_1
{
    internal class Program
    {
        static void Main()
        {
            Start:

            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("");
            Console.WriteLine("To go back, please write 'back'. ");
            Console.WriteLine("");
            Console.WriteLine("Please select which process you want: ");
            string sprocess = Console.ReadLine();
            int iprocess;
            bool successg = int.TryParse(sprocess, out iprocess);
            int selection = iprocess;

            //addition
            if (sprocess.ToLower() == "addition" || selection == 1)
            {
                Console.WriteLine("Please write the number of numbers you want to use in the operation: ");
                string inputnfn = Console.ReadLine();
                int nfn;
                int counter = 0;
                int result = 0;
                bool success = int.TryParse(inputnfn, out nfn);

                if (inputnfn.ToLower() == "back")
                {
                    goto Start;
                }

                while (success && counter < nfn)
                {
                    Console.WriteLine("Enter a number: ");
                    string input = Console.ReadLine();
                    int number;
                    bool success1 = int.TryParse(input, out number);

                    if (input.ToLower() == "back")
                    {
                        goto Start;
                    }

                    if (success1)
                    {
                        result += number;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid nfn number.");
                    }
                }
                Console.WriteLine("The result of the addition operation: " + result);
                goto Start;

            }

            //subtraction
            else if (sprocess.ToLower() == "subtraction" || selection == 2)
            {
                Console.WriteLine("Please write the number you would like to subtract: ");
                string inputb = Console.ReadLine();
                int numberb;
                bool success = int.TryParse(inputb, out numberb);

                if (inputb.ToLower() == "back")
                {
                    goto Start;
                }

                if (success)
                {
                    Console.WriteLine("Please write how many times you would like to subtract a number from" + numberb);
                    string inputc = Console.ReadLine();
                    int numberc;
                    bool success1 = int.TryParse(inputc, out numberc);

                    if (inputc.ToLower() == "back")
                    {
                        goto Start;
                    }

                    if (success1)
                    {
                        int counter = 0;
                        while (counter < numberc)
                        {
                            Console.WriteLine("Please enter number you wanna subtrack from: " + numberb);
                            string inputvn = Console.ReadLine();
                            int number;
                            int result = 0;
                            bool success2 = int.TryParse(inputvn, out number);

                            if (inputvn.ToLower() == "back")
                            {
                                goto Start;
                            }

                            if (success2)
                            {
                                result = numberb = numberb - number;
                                counter++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            Console.WriteLine("The result of the subtraction operation: " + result);
                            goto Start;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                }
            }

            //multiplication
            else if (sprocess.ToLower() == "multiplication" || selection == 3)
            {
                Console.WriteLine("Please write number of numbers u wanna use in this operation: ");
                string inputnfn = Console.ReadLine();
                int nfn;
                int counter = 0;
                int result = 1;
                bool success = int.TryParse(inputnfn, out nfn);

                if (inputnfn.ToLower() == "back")
                {
                    goto Start;
                }

                while (success && counter < nfn)
                {
                    Console.WriteLine("Enter a number");
                    string input = Console.ReadLine();
                    int number;
                    bool success2 = int.TryParse(input, out number);

                    if (input.ToLower() == "back")
                    {
                        goto Start;
                    }

                    if (success2)
                    {
                        result *= number;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                Console.WriteLine("The result of multiplication operation: " + result);
                goto Start;

            }

            //division
            else if (sprocess.ToLower() == "division" || selection == 4)
            {
                Console.WriteLine("Please write the number you would like to divide: ");
                string inputb = Console.ReadLine();
                double numberb;
                bool success = double.TryParse(inputb, out numberb);

                if (inputb.ToLower() == "back")
                {
                    goto Start;
                }

                if (success)
                {
                    Console.WriteLine("Please write how many times you would like to divide a number from" + numberb);
                    string inputc = Console.ReadLine();
                    int numberc;
                    bool success1 = int.TryParse(inputc, out numberc);
                    if (success1)
                    {
                        int counter = 0;
                        while (counter < numberc)
                        {
                            Console.WriteLine("Please enter number you wanna subtrack from: " + numberb);
                            string inputvn = Console.ReadLine();
                            double number;
                            double result = 1;
                            bool success2 = double.TryParse(inputvn, out number);

                            if (inputvn.ToLower() == "back")
                            {
                                goto Start;
                            }

                            if (success2)
                            {
                                result = numberb = numberb / number;
                                counter++;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            Console.WriteLine("The result of the divide operation: " + result);
                            if (counter == numberc - 1)
                            {
                                goto Start;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                }
            }
        }
    }
}