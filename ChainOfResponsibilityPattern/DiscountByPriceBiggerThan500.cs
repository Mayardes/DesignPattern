namespace DesignPatterns.ChainOfResponsibilityPattern;

public class DiscountByPriceBiggerThan500 : IDiscount
{
    public IDiscount NextDiscount { get; set; }
    public decimal ToCalculate(Budget budget)
    {
        return budget.Value > 500 ? budget.Value * 0.07m : NextDiscount.ToCalculate(budget);
    }
}