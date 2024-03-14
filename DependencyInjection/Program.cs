using DependencyInjection;



var gameLogic = new RGBGame();
var userInputHandler = new UserInputHandler();
var game = new GameEngine(gameLogic, userInputHandler);
game.PlayGame();







// var gc = new GameChanger();
// do
// {
//     var result = gc.PlayGame();

//     switch (result)
//     {
//         case Result.Human:
//             Console.WriteLine($"{Environment.NewLine} Player 1 Wins");
//             break;
//         case Result.Computer:
//             Console.WriteLine($"{Environment.NewLine} Player 2 Wins");
//             break;
//         default:
//             Console.WriteLine($"{Environment.NewLine} It's a Draw!");
//             break;
//     }
// } while (Console.ReadLine().ToUpper() == "Y");
