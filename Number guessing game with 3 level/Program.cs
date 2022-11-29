using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guessing_game_with_3_level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mybool = true;

            while (mybool)
            {  
                Console.WriteLine("Welcome to Guessing game. Try you guess the number. We have 3 level");
                Console.WriteLine("Choose the action you want to do: ");
                Console.WriteLine("1. Entry Level");
                Console.WriteLine("2. Intermediate Level");
                Console.WriteLine("3. Difficult Level");
                Console.WriteLine("4. Exit");
                string selectedAction = Console.ReadLine();
            
                switch (selectedAction)
                {
                case "1":
                    Console.WriteLine("Welcome to Entry Level. You will get 5 chances guess the number between 1-20");
                    Console.WriteLine("1. Entry Level");

                    Random Number = new Random();
                    int returnValue = Number.Next(1, 20);


                    for (int i = 0; i < 5; i++)
                    {

                        bool numGuess = Int32.TryParse(Console.ReadLine(), out var userinput); // convert from string to int.// var better than int or string.  

                        if (!numGuess)
                        {
                            Console.WriteLine("You may write NUMBER instead!");
                            continue;
                        }
                        else
                        {
                            if (userinput == returnValue)
                            {
                                Console.WriteLine("You have guess right!");
                            }
                            else if (userinput < returnValue)
                            {
                                if (userinput < 5)
                                {
                                    Console.WriteLine("You are not near by.");
                                }
                                else if (userinput < 10)
                                {
                                    Console.WriteLine("You are out of range.");
                                }
                                else if (userinput < 15)
                                {
                                    Console.WriteLine("You are way of away.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, you guessed too low!");
                                }
                            }
                            else
                            {
                                if (userinput > 5)
                                {
                                    Console.WriteLine("You are near by.");
                                }
                                else if (userinput > 10)
                                {
                                    Console.WriteLine("Unfortunately, you guessed too high!");
                                }
                                else if (userinput > 15)
                                {
                                    Console.WriteLine("Haha! That was too loud!");
                                }
                                else
                                {
                                    Console.WriteLine("Good guess but that was too high!");
                                }
                            }
                        }

                        if (i == 4)
                        {
                            Console.WriteLine("You have tried 5 times. And you are failed.");

                        }
                    }
                    break;
                 
                case "2":

                    Console.WriteLine("Welcome to Intermediate Level. You will get 6 chances guess the number between 1-50");
                    Console.WriteLine("2. Intermediate Level");

                    Random Number1 = new Random();
                    int returnValue1 = Number1.Next(1, 50);


                    for (int i = 0; i < 7; i++)
                    {

                        bool numGuess = Int32.TryParse(Console.ReadLine(), out var userinput); // convert from string to int.// var better than int or string.  

                        if (!numGuess)
                        {
                            Console.WriteLine("You may write NUMBER instead!");
                            continue;
                        }
                        else
                        {
                            if (userinput == returnValue1)
                            {
                                Console.WriteLine("You have guess right!");
                            }
                            else if (userinput < returnValue1)
                            {
                                Console.WriteLine("Sorry, you guessed too low!");
                            }
                            else
                            {
                                Console.WriteLine("Good guess but that was too high!");
                            }
                        }

                        if (i == 6)
                        {
                            Console.WriteLine("You have tried 6 times. And you are failed.");

                        }
                    }
                    break;

                case"3":
                    Console.WriteLine("Welcome to Difficult Level. You will get 10 chances guess the number between 1-100");
                    Console.WriteLine("3. Difficult Level");

                    Random Number2 = new Random();
                    int returnValue2 = Number2.Next(1, 100);


                    for (int i = 0; i < 11; i++)
                    {

                        bool numGuess = Int32.TryParse(Console.ReadLine(), out var userinput); // convert from string to int.// var better than int or string.  

                        if (!numGuess)
                        {
                            Console.WriteLine("You may write NUMBER instead!");
                            continue;
                        }
                        else
                        {
                            if (userinput == returnValue2)
                            {
                                Console.WriteLine("You have guess right!");
                            }
                            else if (userinput < returnValue2)
                            {
                                Console.WriteLine("Sorry, you guessed too low!");
                            }
                            else
                            {
                                Console.WriteLine("Good guess but that was too high!");
                            }
                        }

                        if (i == 10)
                        {
                            Console.WriteLine("You have tried 5 times. And you are failed.");

                        }
                    }
                    break;
                    case "4":
                        mybool = false;
                    break;

                
                }
            }
        }
    }
}
