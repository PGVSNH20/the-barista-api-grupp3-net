using BaristaApi.Beverages;
using Xunit;

namespace BaristaAPI.tests
{
    public class FluentApiTests
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso()
        {

            // Act
            var beverage = new FluentEspresso().AddWater(20).AddBeans().ToBeverage();

            // Assert
            Assert.IsType<Espresso>(beverage);
        }

        [Fact]
        public void When_AddingEspressoAndMilk_Expect_Latte()
        {

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().ToBeverage();

            // Assert
            Assert.IsType<Latte>(bev);
        }

        [Fact]
        public void When_AddingEspressoMilkAndChocolateSyrup_Expect_Mocha()
        {

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().AddChocolateSyrup().ToBeverage();

            // Assert
            Assert.IsType<Mocha>(bev);
        }

        [Fact]
        public void When_AddingEspressoMilkFoam_Expect_Macchiato()
        {

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilkFoam().ToBeverage();

            // Assert
            Assert.IsType<Macchiato>(bev);
        }

        [Fact]
        public void When_AddingEspressoAndWater_Expect_Americano()
        {

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddBeans().AddWater(0).ToBeverage();

            // Assert
            Assert.IsType<Americano>(bev);
        }

        [Fact]
        public void When_AddingEspressoMilkAndMilkFoam_Expect_Cappuccino()
        {

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().AddMilkFoam().ToBeverage();

            // Assert
            Assert.IsType<Cappuccino>(bev);
        }

        [Fact]
        public void When_AddingRandomStuff_Expect_CustomBeverage()
        {

            // Act
            var bev = new FluentEspresso().AddWater(20).AddBeans().AddMilk().AddMilkFoam().AddChocolateSyrup().ToBeverage();

            // Assert
            Assert.IsType<CustomBeverage>(bev);
        }
    }
}
