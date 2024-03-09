namespace DesignPatterns.TemplateMethodPattern;

public class Ikcv : TemplateConditionalTax
{
    public override bool MustUseMaximumTax(Budget budget)
    {
        return budget.Value > 500 && HasProductBiggerThan100(budget);
    }

    public override decimal MaximumTax(Budget budget)
    {
        return budget.Value * 0.10m;
    }

    public override decimal MinimumTax(Budget budget)
    {
        return budget.Value * 0.07m;
    }

    private bool HasProductBiggerThan100(Budget budget)
    {
        return budget.Products.Exists(x => x.Price > 100);
    }
}