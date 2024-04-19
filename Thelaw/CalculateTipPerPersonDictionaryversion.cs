using System;
using System.Collections.Generic;
using System.Linq;

public class TipCalculator
{
    public Dictionary<string, decimal> CalculateTipPerPerson(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if (mealCosts == null || mealCosts.Count == 0)
            throw new ArgumentException("Meal costs dictionary is null or empty.");

        if (tipPercentage < 0)
            throw new ArgumentException("Tip percentage cannot be negative.");

        decimal totalMealCost = mealCosts.Values.Sum();
        decimal tipAmount = totalMealCost * (decimal)(tipPercentage / 100);
        decimal totalBill = totalMealCost + tipAmount;

        Dictionary<string, decimal> tipPerPerson = new Dictionary<string, decimal>();
        foreach (var pair in mealCosts)
        {
            decimal individualTip = pair.Value / totalMealCost * tipAmount;
            tipPerPerson.Add(pair.Key, individualTip);
        }

        return tipPerPerson;
    }
}
