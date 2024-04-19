using System;
using Xunit;

public class TipCalculatorTests
{
    [Fact]
    public void CalculateTipPerPerson_ReturnsCorrectTipAmountPerPerson()
    {
        // Arrange
        TipCalculator tipCalculator = new TipCalculator();
        decimal price = 100.0m;
        int numberOfPatrons = 4;
        float tipPercentage = 15.0f;

        // Act
        decimal tipPerPerson = tipCalculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

        // Assert
        decimal expectedTipPerPerson = 3.75m;
        Assert.Equal(expectedTipPerPerson, tipPerPerson);
    }

    // 
}
