using System;
using System.Linq;

static class SavingsAccount
{
    public static float InterestRate(decimal balance) =>
        balance switch
        {
            >= 0m and < 1000m => 0.5f,
            >= 1000.0m and < 5000.0m => 1.621f,
            >= 5000.0m => 2.475f,
            _ => 3.213f
        };

    public static decimal Interest(decimal balance) =>
        balance * (decimal)InterestRate(balance) / 100m;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }

}
