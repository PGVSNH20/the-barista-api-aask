using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso()
        {
            var beverage = new EspressoMachine().AddWater(25).AddBeans(CoffeSorts.Robusta).ToBeverage();
            Assert.IsType<Espresso>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndMilk_Expect_Latte()
        {
            var beverage = new EspressoMachine().AddWater(25).AddBeans(CoffeSorts.Robusta).AddMilk().ToBeverage();
            Assert.IsType<Latte>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndMilkAndMilkFoam_Expect_Cappuccino()
        {
            var beverage = new EspressoMachine().AddWater(25).AddBeans(CoffeSorts.Robusta).AddMilk().AddMilkFoam().ToBeverage();
            Assert.IsType<Cappuccino>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeans_Expect_Americano()
        {
            var beverage = new EspressoMachine().AddWater(25).AddBeans(CoffeSorts.Robusta).ToBeverage();
            Assert.IsType<Americano>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndChocolateSyrupAndMilk_Expect_Mocha()
        {
            var beverage = new EspressoMachine().AddWater(25).AddBeans(CoffeSorts.Robusta).AddChocolateSyrup().AddMilk().ToBeverage();
            Assert.IsType<Mocha>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndMilkFoam_Expect_Macchiato()
        {
            var beverage = new EspressoMachine().AddWater(25).AddBeans(CoffeSorts.Robusta).AddMilkFoam().ToBeverage();
            Assert.IsType<Macchiato>(beverage);
        }

        [Fact]
        public void When_AddingOnlyBeans_Expect_CustomBeverage()
        {
            var beverage = new EspressoMachine().AddBeans(CoffeSorts.Robusta).ToBeverage();
            Assert.IsType<CustomBeverage>(beverage);
        }
    }
}