namespace DesignPatterns.StrategyPattern;

public class ICMS : ITax
{
    public decimal ToCalculate(Budget budget)
    {
        return budget.Value * 0.10m;
    }
}