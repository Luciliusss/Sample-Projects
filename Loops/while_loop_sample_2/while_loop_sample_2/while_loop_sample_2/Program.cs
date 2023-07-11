using System;
using System.Security.Cryptography;

namespace while_sample_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Triangle
            /*
            int row = 1;
            int maxrow = 5;

            while (row <= maxrow)
            {
                int stars = 1;

                while (stars <= row)
                {
                    Console.Write("* ");
                    stars++;
                }
                Console.WriteLine();
                row++;
            }
            Console.ReadLine();
            */


            //-Inverted-Triangle
            /*
            int row = 5;
            int maxrow = 5;
            while (row <= maxrow)
            {
                if (row <= 0)
                {
                    break;
                }
                int stars = 1;

                while (stars <= row)
                {
                    Console.Write("* ");
                    stars++;    
                }
                Console.WriteLine();
                row--;
            }
            Console.ReadLine();
            */


            //-square
            /*
            int sqr = 5;
            int count = 1;

            while (count <= sqr)
            {
                int cntsqr = 1;
                while (cntsqr <= sqr)
                {
                    Console.Write("* ");
                    cntsqr++;
                }
                Console.WriteLine();
                count++;
            }
            */

            
            //-Empty-Square
            /*
            int sqr = 5;
            int row = 1;

            while (row <= sqr)
            {
                int col = 1;
                while (col <= sqr)
                {
                    if (row == 1 || row == sqr || col ==1 || col == sqr)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    col++;
                }
                Console.WriteLine();
                row++;
            }*/

            
            //-Triangle
            /*
            int sqr = 5;
            int count = 1;

            while (count <= sqr)
            {
                for (int col = 1; col <= sqr - count; col++)
                {
                    Console.Write("  ");
                }

                for (int col = 1; col <= 2 * count - 1; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                count++;
            }*/

            //-empty-Triangle
            int height = 4;
            int cnt = 1;

            while (cnt <= height)
            {
                int c1 = 1;
                while (c1 <= height - cnt)
                {
                    Console.Write("  ");
                    c1++;
                }

                if (cnt == 1 || cnt == height)
                {
                    int c2 = 1;
                    while (c2 <= 2 * cnt -1)
                    {
                        Console.Write("* ");

                        c2++;
                    }
                }
                else if (cnt != 1|| cnt != height)
                {
                    int c3 = 1;
                    while (c3 <= 2 * cnt - 1)
                    {
                        Console.Write("*");
                        for (int i = 1; i <= 4 * cnt - 5; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        break;
                    }
                }
                
                Console.WriteLine();
                cnt++;
            }

        }
    }
}