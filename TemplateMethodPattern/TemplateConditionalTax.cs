namespace DesignPatterns.TemplateMethodPattern;

public abstract class TemplateConditionalTax : ITax
{
    public decimal ToCalculate(Budget budget)
    {
        return MustUseMaximumTax(budget) ? MaximumTax(budget) : MinimumTax(budget);
    }

    public abstract bool MustUseMaximumTax(Budget budget);
    public abstract decimal MaximumTax(Budget budget);
    public abstract decimal MinimumTax(Budget budget);
}