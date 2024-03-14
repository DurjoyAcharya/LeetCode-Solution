
//Simple color picker game
namespace DependencyInjection
{
    public enum Options
    {
        RED, GREEN, BLUE
    }
    public enum Result
    {
        Human, Computer, Draw
    }
    public class GameChanger
    {
        private Random _rand = new Random();
        private Options _human;
        //Player Human
        public Result PlayGame()
        {
            string? input = "";
            do
            {
                Console.Write($"{Environment.NewLine} Enter Option: (R)ed, (G)reen or (B)lue !");
                input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "R":
                        _human = Options.RED;
                        break;
                    case "G":
                        _human = Options.GREEN;
                        break;
                    case "B":
                        _human = Options.BLUE;
                        break;
                    default:
                        Console.WriteLine($"{Environment.NewLine} Wrong Option. Please try again!");
                        break;
                }
            } while (input != "R" && input != "G" && input != "B");

            //Player 2 Computer
            Options _computer = (Options)_rand.Next(0, 3);
            Console.Write($"{Environment.NewLine}Player 2 Picked {_computer.ToString()}");
            if (_human.Equals(_computer))
                return Result.Draw;

            //Some Dummy logic 
            if (_human == Options.RED && _computer == Options.GREEN
                || _human == Options.BLUE && _computer == Options.RED || _human == Options.GREEN && _computer == Options.BLUE)
                return Result.Human;
            return Result.Computer;
        }
    }
}