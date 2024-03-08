namespace DesignPatterns.ChainOfResponsibilityPattern;

public class CalculatorDiscount
{
    public decimal ToCalculate(Budget budget)
    {
        var d1 = new DiscountBy5Products();
        var d2 = new DiscountByPriceBiggerThan500();
        var d3 = new DiscountZero();

        d1.NextDiscount = d2;
        d2.NextDiscount = d3;

        return d1.ToCalculate(budget);
    }
}