using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GetAppInfo();

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not a number!");
                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Congrats you win!");
                Console.ResetColor();

              
                Console.WriteLine("Play again? [Y o N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
                
            }


            static void GetAppInfo() {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Number guesser!");
                Console.ResetColor();

                Console.WriteLine("What's your name?");
                string inputName = Console.ReadLine();
                Console.WriteLine("Hello {0}, let's play..", inputName);

            }
        }
    }
}
