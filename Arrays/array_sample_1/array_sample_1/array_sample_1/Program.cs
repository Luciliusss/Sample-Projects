using System;
using System.Globalization;

namespace array_sample_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] number = new int[5];
            int j = 10;
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("sayı gir : ");
                j = Convert.ToInt32(Console.ReadLine());
                number[i] = j;
                Console.WriteLine(i + " numaralı array'a " + number[i] + " atandı");
             }
             */

            /*------------------------------*/

            /*
            int[] numbers = { 1, 2, 3, 4, 5};
            int newSize = numbers.Length +1;
            int[] newNumbers = new int[newSize];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = numbers[i];
            }

            newNumbers[newSize - 1] = 6;
            numbers = newNumbers;

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers[5]);
            

            /*------------------------------*/

            /*
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[3]);
            numbers[2] = 10;
            Console.WriteLine(numbers[2]);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            /*------------------------------*/

            /*
            int[] numbers = { 5, 2, 1, 3, 4 };
            Array.Sort(numbers);
            
            Console.WriteLine("dizi elemanlarının tersten sıralı hali:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            /*------------------------------*/

            /*
            int[] numbers = { 1, 2, 3, 4, 5};
            Array.Reverse(numbers);
            Console.WriteLine("Dizi elemanlarının tersten sıralı hali:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            /*------------------------------*/


        }
    }
}
