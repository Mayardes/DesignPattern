namespace DesignPatterns.TemplateMethodPattern;

public class Budget
{
    public Budget(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; private set; }
    public List<Product> Products { get; private set; }
}