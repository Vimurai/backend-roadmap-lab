using Xunit;
using RoadmapLab.CsharpLanguageCore;
using System;

namespace RoadmapLab.CsharpLanguageCore.Tests
{
    public class CoffeeMachineTests
    {
        [Fact]
        public void MakeCoffee_WithEnoughIngredients_ShouldSucceed()
        {
            // Arrange
            var machine = new CoffeeMachine();
            machine.Fill(100, 20); // Enough for 2 coffees

            // Act
            bool result = machine.MakeCoffee();

            // Assert
            Assert.True(result);
            // We can't easily check internal state unless we expose it, 
            // but we can check if it throws or not.
        }

        [Fact]
        public void MakeCoffee_NotEnoughWater_ShouldThrow()
        {
            // Arrange
            var machine = new CoffeeMachine();
            machine.Fill(10, 100); // Low water

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => machine.MakeCoffee());
            Assert.Equal("Not enough water", ex.Message);
        }

        [Fact]
        public void MakeCoffee_NotEnoughBeans_ShouldThrow()
        {
            // Arrange
            var machine = new CoffeeMachine();
            machine.Fill(100, 5); // Low beans

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => machine.MakeCoffee());
            Assert.Equal("Not enough beans", ex.Message);
        }
    }
}