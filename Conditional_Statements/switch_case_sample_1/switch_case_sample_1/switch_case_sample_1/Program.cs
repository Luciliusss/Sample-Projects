using System;

namespace switch_case_sample_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int dayofweek = (int)DateTime.Now.DayOfWeek;

            switch (dayofweek)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wendesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("There is no day :)");
                    break;
            }
        }

    }
}