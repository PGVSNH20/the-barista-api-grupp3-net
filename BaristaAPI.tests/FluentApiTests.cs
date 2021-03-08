using BaristaApi.Beverages;
using Xunit;

namespace BaristaAPI.tests
{
    public class FluentApiTests
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var beverage = new FluentEspresso().AddWater(20).AddBeans().ToBeverage();

            // Assert
            Assert.IsType<Espresso>(beverage);
        }
    }
}
