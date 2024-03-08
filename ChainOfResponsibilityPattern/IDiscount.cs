namespace DesignPatterns.ChainOfResponsibilityPattern;

public interface IDiscount
{
    decimal ToCalculate(Budget budget);
    IDiscount NextDiscount { get; set; }
}