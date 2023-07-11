using System;
using System.Linq;
using System.Collections.Generic;

namespace char_sample_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("If you want just letter seperate write 1 or if you want to seperate everythink write 2");
            string inputltrornot = Console.ReadLine();
            int ltrsprt;
            bool successltr = int.TryParse(inputltrornot, out ltrsprt);

            if (successltr)
            {
                if (ltrsprt == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine("For upper letter separate write 1, for lower letter seperate write 2, for upper and lower letter seperate write 3.");
                    string inputsprt = Console.ReadLine();
                    int sprt;
                    bool success = int.TryParse(inputsprt, out sprt);

                    if (success)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        //upper
                        if (sprt == 1)
                        {
                            Console.WriteLine("Enter a text:");
                            string input = Console.ReadLine();
                            string resultupr = new string(input.Where(char.IsUpper).ToArray());

                            Dictionary<char, int> characterFrequency = CalculateCharacterFrequencyupper(resultupr);
                            
                            Console.WriteLine("Frequency of letter:");
                            foreach (var kvp in characterFrequency)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                        }

                        //lower
                        else if (sprt == 2)
                        {
                            Console.WriteLine("Enter a text:");
                            string input = Console.ReadLine();
                            string resultlwr = new string(input.Where(char.IsLower).ToArray());

                            Dictionary<char, int> characterFrequency = CalculateCharacterFrequencylower(resultlwr);

                            Console.WriteLine("Frequency of letter:");
                            foreach (var kvp in characterFrequency)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                        }

                        //upper and lower
                        else if (sprt == 3)
                        {
                            Console.WriteLine("Enter a text:");
                            string resultuprandlwr = Console.ReadLine();

                            Dictionary<char, int> characterFrequency = CalculateCharacterFrequencyupperandlower(resultuprandlwr);

                            Console.WriteLine("Frequency of letter:");
                            foreach (var kvp in characterFrequency)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter valid input.");
                        goto Start;
                    }
                }

                else if (ltrsprt == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine("For upper letter separate write 1, for lower letter seperate write 2, for upper and lower letter seperate write 3.");
                    string inputsprt = Console.ReadLine();
                    int sprt;
                    bool success = int.TryParse(inputsprt, out sprt);

                    if (success)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        //upper
                        if (sprt == 1)
                        {
                            Console.WriteLine("Enter a text:");
                            string input = Console.ReadLine();
                            string resultupr = new string(input.Where(c => !char.IsLower(c)).ToArray());
                            

                            Dictionary<char, int> characterFrequency = CalculateCharacterFrequencyupperandallinput(resultupr);

                            Console.WriteLine("Frequency of letter:");
                            foreach (var kvp in characterFrequency)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                        }

                        //lower
                        else if (sprt == 2)
                        {
                            Console.WriteLine("Enter a text:");
                            string input = Console.ReadLine();
                            string resultlwr = new string(input.Where(c => !char.IsUpper(c)).ToArray());

                            Dictionary<char, int> characterFrequency = CalculateCharacterFrequencylowerandallinput(resultlwr);

                            Console.WriteLine("Frequency of letter:");
                            foreach (var kvp in characterFrequency)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                        }

                        //upper and lower
                        else if (sprt == 3)
                        {
                            Console.WriteLine("Enter a text:");
                            string resultuprandlwr = Console.ReadLine();

                            Dictionary<char, int> characterFrequency = CalculateCharacterFrequencyallinput(resultuprandlwr);

                            Console.WriteLine("Frequency of letter:");
                            foreach (var kvp in characterFrequency)
                            {
                                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter valid input.");
                        goto Start;
                    }
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid input");
                goto Start;
            }

            //upper all input method
            static Dictionary<char, int> CalculateCharacterFrequencyupperandallinput(string resultupr)
            {
                Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

                foreach (char c in resultupr)
                {
                    // update the frequency of letter 
                    if (characterFrequency.ContainsKey(c))
                    {
                        characterFrequency[c]++;
                    }
                    else
                    {
                        characterFrequency[c] = 1;
                    }
                }

                return characterFrequency;
            }

            //lower all input method
            static Dictionary<char, int> CalculateCharacterFrequencylowerandallinput(string resultlwr)
            {
                Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

                foreach (char c in resultlwr)
                {
                    // update the frequency of letter 
                    if (characterFrequency.ContainsKey(c))
                    {
                        characterFrequency[c]++;
                    }
                    else
                    {
                        characterFrequency[c] = 1;
                    }
                }

                return characterFrequency;
            }

            //all input method
            static Dictionary<char, int> CalculateCharacterFrequencyallinput(string resultuprandlwr)
            {
                Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

                foreach (char c in resultuprandlwr)
                {
                    // update the frequency of letter 
                    if (characterFrequency.ContainsKey(c))
                    {
                        characterFrequency[c]++;
                    }
                    else
                    {
                        characterFrequency[c] = 1;
                    }
                }

                return characterFrequency;
            }

            //upper letter method
            static Dictionary<char, int> CalculateCharacterFrequencyupper(string resultupr)
            {
                Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

                foreach (char c in resultupr)
                {
                    // Check the letters
                    if (char.IsLetter(c))
                    {
                        // update the frequency of letter 
                        if (characterFrequency.ContainsKey(c))
                        {
                            characterFrequency[c]++;
                        }
                        else
                        {
                            characterFrequency[c] = 1;
                        }
                    }
                }

                return characterFrequency;
            }

            //lower method
            static Dictionary<char, int> CalculateCharacterFrequencylower(string resultlwr)
            {
                Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

                foreach (char c in resultlwr)
                {
                    //Check the letters
                    if (char.IsLetter(c))
                    {
                        // update the frequency of letter 
                        if (characterFrequency.ContainsKey(c))
                        {
                            characterFrequency[c]++;
                        }
                        else
                        {
                            characterFrequency[c] = 1;
                        }
                    }
                }

                return characterFrequency;
            }


            //upper and lower method
            static Dictionary<char, int> CalculateCharacterFrequencyupperandlower(string resultuprandlwr)
            {
                Dictionary<char, int> characterFrequency = new Dictionary<char, int>();

                foreach (char c in resultuprandlwr)
                {
                    // Check the letters
                    if (char.IsLetter(c))
                    {
                        // update the frequency of letter 
                        if (characterFrequency.ContainsKey(c))
                        {
                            characterFrequency[c]++;
                        }
                        else
                        {
                            characterFrequency[c] = 1;
                        }
                    }
                }

                return characterFrequency;
            }
        }
    }
}