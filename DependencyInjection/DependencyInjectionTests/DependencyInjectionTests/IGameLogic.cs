namespace DependencyInjectionTests
{
    public enum Options
    {
        RED,
        GREEN,
        BLUE
    }

    public enum Result
    {
        Human,
        Computer,
        Draw
    }

    public interface IGameLogic
    {
        Result PlayGame(Options humanChoice, Options computerChoice);
    }

    public class RGBGame : IGameLogic
    {
        public Result PlayGame(Options humanChoice, Options computerChoice)
        {
            if (humanChoice.Equals(computerChoice))
            {
                return Result.Draw;
            }

            // Implement game logic (assuming RED > GREEN, GREEN > BLUE, BLUE > RED)
            //Dummy logic you need not to follow it 
            return humanChoice switch
            {
                Options.RED when computerChoice == Options.GREEN => Result.Computer,
                Options.GREEN when computerChoice == Options.BLUE => Result.Computer,
                Options.BLUE when computerChoice == Options.RED => Result.Computer,
                _ => Result.Human
            };
        }
    }
}