namespace DependencyInjection
{
    public class GameEngine
    {
        private readonly IGameLogic _gameLogic;
        private readonly UserInputHandler _userInputHandler;
        //constructor injection 
        public GameEngine(IGameLogic gameLogic, UserInputHandler userInputHandler)
        {
            _gameLogic = gameLogic;
            _userInputHandler = userInputHandler;
        }
        public void PlayGame()
        {
            do
            {
                var humanChoice = _userInputHandler.GetPlayerChoice();
                var computerChoice = (Options)new Random().Next(0, 3);
                Console.Write($"{Environment.NewLine}Player 2 Picked: {computerChoice.ToString()}");

                var result = _gameLogic.PlayGame(humanChoice, computerChoice);

                switch (result)
                {
                    case Result.Human:
                        Console.Write($"{Environment.NewLine} Player 1 Wins!");
                        break;
                    case Result.Computer:
                        Console.Write($"{Environment.NewLine} Player 2 Wins!");
                        break;
                    default:
                        Console.Write($"{Environment.NewLine} It's a Draw!");
                        break;
                }
                Console.Write($"{Environment.NewLine} Play Again! Press (Y)!");

            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}