using System;
using Xunit;

public class SplitterTests
{
    [Fact]
    public void SplitAmountByNumberOfPeople_ReturnsCorrectAmount()
    {
        // Arrange
        Splitter splitter = new Splitter();
        decimal totalAmount = 100.0m;
        int numberOfPeople = 5;

        // Act
        decimal splitAmount = splitter.SplitAmountByNumberOfPeople(totalAmount, numberOfPeople);

        // Assert
        decimal expectedSplitAmount = 20.0m;
        Assert.Equal(expectedSplitAmount, splitAmount);
    }

    // 
}
