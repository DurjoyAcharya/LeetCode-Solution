using Xunit;
namespace DependencyInjectionTests
{
    public class UserInputHandlerTests
    {
        [Fact]
        public void ReturnsCorrectOptionForValidInput()
        {
            var userInputHandler = new UserInputHandler();
            Assert.Equal(Options.RED, userInputHandler.GetPlayerChoice()); // Simulate user input "R"
            Assert.Equal(Options.GREEN, userInputHandler.GetPlayerChoice()); // Simulate user input "G"
            Assert.Equal(Options.BLUE, userInputHandler.GetPlayerChoice()); // Simulate user input "B"
        }

    }
}