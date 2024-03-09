namespace DesignPatterns.TemplateMethodPattern;

public class Icpp : TemplateConditionalTax
{
    public override bool MustUseMaximumTax(Budget budget)
    {
        return budget.Value >= 500;
    }

    public override decimal MaximumTax(Budget budget)
    {
        return budget.Value * 0.07m;
    }

    public override decimal MinimumTax(Budget budget)
    {
        return budget.Value * 0.01m;
    }
}