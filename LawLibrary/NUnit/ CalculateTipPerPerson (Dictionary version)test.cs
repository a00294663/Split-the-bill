using System;
using System.Collections.Generic;
using Xunit;

public class TipCalculatorTests
{
    [Fact]
    public void CalculateTipPerPerson_ReturnsCorrectTipAmountPerPerson()
    {
        // Arrange
        TipCalculator tipCalculator = new TipCalculator();
        var mealCosts = new Dictionary<string, decimal>
        {
            { "Alice", 25.0m },
            { "Bob", 30.0m },
            { "Charlie", 20.0m }
        };
        float tipPercentage = 15.0f;

        // Act
        var tipPerPerson = tipCalculator.CalculateTipPerPerson(mealCosts, tipPercentage);

        // Assert
        Assert.Equal(6.25m, tipPerPerson["Alice"]);
        Assert.Equal(7.50m, tipPerPerson["Bob"]);
        Assert.Equal(5.0m, tipPerPerson["Charlie"]);
    }

    // Add more test cases as needed
}
