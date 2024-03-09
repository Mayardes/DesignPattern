namespace DesignPatterns.TemplateMethodPattern;

public interface ITax
{
    decimal ToCalculate(Budget budget);
}