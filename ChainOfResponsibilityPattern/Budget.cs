namespace DesignPatterns.ChainOfResponsibilityPattern;

public class Budget
{
    public Budget(decimal value)
    {
        Value = value;
        Products = new List<Product>();
    }

    public decimal Value { get; private set; }
    public List<Product> Products { get; private set; }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
}