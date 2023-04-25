using Breakfast.Services;
using Xunit;

namespace Breakfast.Tests
{
    public class BreakfastServiceTests
    {
        [Fact]
        public void GetMenu_Should_Return_Menu()
        {
            // Arrange
            var service = new BreakfastService();

            // Act
            var menu = service.GetMenu();

            // Assert
            Assert.NotNull(menu);
            Assert.NotEmpty(menu.Items);
            Assert.Contains(menu.Items, item => item.Name == "Scrambled Eggs");
            Assert.Contains(menu.Items, item => item.Name == "Pancakes");
            Assert.Contains(menu.Items, item => item.Name == "Bacon");
        }
    }
}
