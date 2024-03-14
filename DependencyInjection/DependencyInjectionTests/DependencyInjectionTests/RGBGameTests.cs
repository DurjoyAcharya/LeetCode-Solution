using System;
using Xunit;

namespace DependencyInjectionTests
{
    public class RGBGameTests
    {
        [Fact]
        public void DrawWhenBothPlayersPickSameOption()
        {
            var gameLogic = new RGBGame();
            Assert.Equal(Result.Draw, gameLogic.PlayGame(Options.RED, Options.RED));
            Assert.Equal(Result.Draw, gameLogic.PlayGame(Options.GREEN, Options.GREEN));
            Assert.Equal(Result.Draw, gameLogic.PlayGame(Options.BLUE, Options.BLUE));
        }
        
        [Fact]
        public void HumanWinsWhenValidCombinations()
        {
            var gameLogic = new RGBGame();
            Assert.Equal(Result.Human, gameLogic.PlayGame(Options.RED, Options.GREEN));
            Assert.Equal(Result.Human, gameLogic.PlayGame(Options.BLUE, Options.RED));
            Assert.Equal(Result.Human, gameLogic.PlayGame(Options.GREEN, Options.BLUE));
        }
        [Fact]
        public void ComputerWinsWhenValidCombinations()
        {
            var gameLogic = new RGBGame();
            Assert.Equal(Result.Computer, gameLogic.PlayGame(Options.GREEN, Options.RED));
            Assert.Equal(Result.Computer, gameLogic.PlayGame(Options.RED, Options.BLUE));
            Assert.Equal(Result.Computer, gameLogic.PlayGame(Options.BLUE, Options.GREEN));
        }
        [Fact]
        public void InvalidInputHandling()
        {
            // Simulate unexpected input for game logic testing
            var gameLogic = new RGBGame();

            // Assert that an exception is thrown or appropriate error handling occurs
            Assert.Throws<ArgumentException>(() => gameLogic.PlayGame(Options.RED, (Options)10)); // Invalid computer choice
        }
    }
}