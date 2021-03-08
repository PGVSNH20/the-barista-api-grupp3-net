﻿using BaristaApi.Beverages;
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
    }
}
