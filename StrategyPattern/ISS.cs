namespace DesignPatterns.StrategyPattern;

public class ISS : ITax
{
    public decimal ToCalculate(Budget budget)
    {
        return budget.Value * 0.06m;
    }
}