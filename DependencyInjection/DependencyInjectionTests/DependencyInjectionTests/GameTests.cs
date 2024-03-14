using Moq;
using Xunit;

namespace DependencyInjectionTests
{
    public class GameTests
    {
        [Fact]
        public void PlaysGameWithMockedDependencies()
        {
            // Mock dependencies
            var mockGameLogic = new Mock<IGameLogic>();
            var mockUserInputHandler = new Mock<UserInputHandler>();

            // Set up expected behavior of mocks
            mockGameLogic.Setup(logic => logic.PlayGame(It.IsAny<Options>(), It.IsAny<Options>()))
                .Returns(Result.Human);
            mockUserInputHandler.Setup(handler => handler.GetPlayerChoice())
                .Returns(Options.RED);

            // Create the game with mocked dependencies
            var game = new GameEngine(mockGameLogic.Object, mockUserInputHandler.Object);

            // Play the game and verify interactions
            game.PlayGame();

            // Assertions (e.g., verify mock method calls, output)
            mockGameLogic.Verify(logic => logic.PlayGame(Options.RED, It.IsAny<Options>()), Times.Once);
            mockUserInputHandler.Verify(handler => handler.GetPlayerChoice(), Times.Once);
        }
    }
}