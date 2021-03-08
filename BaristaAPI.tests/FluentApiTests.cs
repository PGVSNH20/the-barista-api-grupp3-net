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

        [Fact]
        public void When_AddingEspressoAndMilk_Expect_Latte()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().ToBeverage();

            // Assert
            Assert.IsType<Latte>(bev);
        }

        [Fact]
        public void When_AddingEspressoMilkAndChocolateSyrup_Expect_Mocha()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().AddChocolateSyrup().ToBeverage();

            // Assert
            Assert.IsType<Mocha>(bev);
        }

        [Fact]
        public void When_AddingEspressoMilkFoam_Expect_Macchiato()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilkFoam().ToBeverage();

            // Assert
            Assert.IsType<Macchiato>(bev);
        }

        [Fact]
        public void When_AddingEspressoAndWater_Expect_Americano()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddWater(5).ToBeverage();

            // Assert
            Assert.IsType<Americano>(bev);
        }

        [Fact]
        public void When_AddingEspressoMilkAndMilkFoam_Expect_Cappuccino()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().AddMilkFoam().ToBeverage();

            // Assert
            Assert.IsType<Cappuccino>(bev);
        }

        [Fact]
        public void When_AddingRandomStuff_Expect_CustomBeverage()
        {
            // Arrange
            //string expected = "Espresso";

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().AddMilkFoam().AddChocolateSyrup().ToBeverage();

            // Assert
            Assert.IsType<CustomBeverage>(bev);
        }
    }
}
