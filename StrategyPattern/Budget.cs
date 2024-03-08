namespace DesignPatterns.StrategyPattern;

public class Budget
{
    public Budget(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; private set; }
}