using System;
using System.Collections.Generic;

namespace RockPaperSissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string CPUInput;
            int userScore = 0;
            int CPUScore = 0;

            var mapDict = new Dictionary <int, string>
            {
                {1, "ROCK"},
                {2, "PAPER"},
                {3, "SCISSORS"}
            };

            
            int roundNum = 1;
            while(roundNum <= 3)
            {
                Console.WriteLine("Round: " + roundNum);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("CPU: " + CPUScore + " - " + "User: " + userScore);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter user input!");
                userInput = Console.ReadLine();
                Random rand = new Random(23);
                CPUInput = mapDict[rand.Next(1,4)];
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(userInput + " vs " + CPUInput);
                switch (userInput)
                {
                    case "ROCK":
                        if(CPUInput == "PAPER")
                        {
                            CPUScore = CPUScore+ 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CPU Won");
                        }
                        else if (CPUInput == "SCISSORS")
                        {
                            userScore += 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Won");
                        }
                        else 
                        {
                            CPUScore += 0;
                            userScore += 0;   
                        };
                        break;

                    case "PAPER":
                        if(CPUInput == "SCISSORS")
                        {
                            CPUScore += 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CPU Won");
                        }
                        else if (CPUInput == "ROCK")
                        {
                            userScore += 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Won");
                        }
                        else 
                        {
                            CPUScore += 0;
                            userScore += 0;   
                        };
                        break;

                    case "SCISSORS":
                        if(CPUInput == "ROCK")
                        {
                            CPUScore += 1;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CPU Won");
                        }
                        else if (CPUInput == "PAPER")
                        {
                            userScore += 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Won");
                        }
                        else 
                        {
                            CPUScore += 0;
                            userScore += 0;   
                        };
                        break;

                    default:
                        break; 
                }
                roundNum += 1;
                Console.WriteLine("********************************************************************");
            }
            if(userScore > CPUScore)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("USER WON");
            } else { Console.WriteLine("CPU WON"); };
                 
        }
    }
}