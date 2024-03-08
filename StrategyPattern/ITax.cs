namespace DesignPatterns.StrategyPattern;

public interface ITax
{
    decimal ToCalculate(Budget budget);
}