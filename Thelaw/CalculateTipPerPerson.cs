using System;

public class Splitter
{
    public decimal SplitAmountByNumberOfPeople(decimal totalAmount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
            throw new ArgumentException("Number of people must be greater than zero.");

        if (totalAmount <= 0)
            throw new ArgumentException("Total amount must be greater than zero.");

        return totalAmount / numberOfPeople;
    }
}
