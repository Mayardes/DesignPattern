// See https://aka.ms/new-console-template for more information

using System.Globalization;
using DesignPatterns.ChainOfResponsibilityPattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.TemplateMethodPattern;
using Budget = DesignPatterns.StrategyPattern.Budget;
using Product = DesignPatterns.ChainOfResponsibilityPattern.Product;

#region strategy_pattern

/*
 * We use abstractions in methods that have the same signature.
 * Separating conditionals into strategic classes with their own implementation responsibilities.
 */

var budget = new Budget(100);
    
var iss = new ISS();
var icms = new ICMS();

var calculatorTaxes = new CalculatorTaxes();
calculatorTaxes.ToCalculate(budget, iss);
calculatorTaxes.ToCalculate(budget, icms);

#endregion

#region chainOfResponsibility_pattern

/**
 * Create a chain with responsibilities
 * Create an interface responsible to represents our discounts
 * and into same interface contains a property that have same type than that interface.
 *
 * In our class that make calculation
 * have this interface that to point to another discount.
 */

var calculatorDiscount = new CalculatorDiscount();
var budget2 = new DesignPatterns.ChainOfResponsibilityPattern.Budget(600);
budget2.AddProduct(new Product("Iphone 13 PRO MAX", 800));
budget2.AddProduct(new Product("Macbook PRO", 2700));

var discount = calculatorDiscount.ToCalculate(budget2);

Console.WriteLine($"Your discount is: {discount.ToString("C", new CultureInfo("pt-BR"))}");

#endregion

#region TemplateMethod_pattern
/*
 * Create a abstract class for implements logic stuctural calculate (template Method)
 * and our concrete classes taxes implements calculate.
 */

var budget3 = new DesignPatterns.TemplateMethodPattern.Budget(200);

var icpp = new Icpp();
var taxIcpp = icpp.ToCalculate(budget3);
Console.WriteLine($"Your tax Icpp is: {taxIcpp.ToString("C", new CultureInfo("pt-BR"))}");

var ikcv = new Ikcv();
var taxIkcv = ikcv.ToCalculate(budget3);
Console.WriteLine($"Your tax Ikcv is: {taxIkcv.ToString("C", new CultureInfo("pt-BR"))}");

#endregion