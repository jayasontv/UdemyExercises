using System;

namespace Udemy.Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            Output.DisplayMessage("Enter 1 to start stopwatch, 2 to stop stopwatch and 3 to exit.");
            int input;
            do
            {
                Output.DisplayMessage("Enter your choice");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out input))
                {
                    try
                    {
                        switch (input)
                        {
                            case 1: stopwatch.Start();
                                break;
                            case 2: stopwatch.Stop();
                                Output.DisplayMessage(string.Format("Duration is {0}", stopwatch.GetDuration()));
                                break;
                            default:
                                break;
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        Output.DisplayMessage("You have selected wrong option");
                    }
                }
                else
                {
                    Output.DisplayMessage("Invalid input");
                }

            } while (input != 3);

        }
    }
}
