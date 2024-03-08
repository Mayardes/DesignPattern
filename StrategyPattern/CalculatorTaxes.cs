using System.Globalization;

namespace DesignPatterns.StrategyPattern;

public class CalculatorTaxes
{
    public void ToCalculate(Budget budget, ITax tax)
    {
        var result = tax.ToCalculate(budget);
        Console.WriteLine(string.Format("Tax {0} is: {1}", tax.GetType().Name, result.ToString("C", new CultureInfo("pt-BR"))));
    }
}