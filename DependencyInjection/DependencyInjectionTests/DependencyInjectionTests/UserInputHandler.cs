using System;

namespace DependencyInjectionTests
{
    public class UserInputHandler
    {
        public Options GetPlayerChoice()
        {
            string? input;
            do
            {
                Console.Write($"{Environment.NewLine} Enter Option: (R)ed, (G)reen or (B)lue !");
                input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "R":
                        return Options.RED;
                    case "G":
                        return Options.GREEN;
                    case "B":
                        return Options.BLUE;
                    default:
                        Console.WriteLine($"{Environment.NewLine} Wrong Option. Please try again!");
                        break;
                }
            } while (true);
        }
    }
}