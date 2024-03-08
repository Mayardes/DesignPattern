namespace DesignPatterns.ChainOfResponsibilityPattern;

public class DiscountBy5Products : IDiscount
{
    public IDiscount NextDiscount { get; set; }

    public decimal ToCalculate(Budget budget)
    {
        return budget.Products.Count > 5 ? budget.Value * 0.1m : NextDiscount.ToCalculate(budget);
    }
}