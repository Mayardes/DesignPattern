using System.Globalization;

namespace DesignPatterns.StrategyPattern;

public class CalculatorTaxes
{
    public void ToCalculate(Budget budget, string taxe)
    {
        if ("icms".Equals(taxe.ToLower()))
        {
            decimal icms = budget.Value * 0.10m;
            Console.WriteLine($"ICMS is {icms.ToString("C", new CultureInfo("pt-BR"))}");
            
        }else if ("iss".Equals(taxe.ToLower()))
        {
            decimal iss = budget.Value * 0.06m;
            Console.WriteLine($"ISS is {iss.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}