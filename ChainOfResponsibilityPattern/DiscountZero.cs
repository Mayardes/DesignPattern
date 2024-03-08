namespace DesignPatterns.ChainOfResponsibilityPattern;

public class DiscountZero : IDiscount
{
    public decimal ToCalculate(Budget budget)
    {
        return 0;
    }

    public IDiscount NextDiscount { get; set; }
}