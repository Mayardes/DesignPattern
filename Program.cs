// See https://aka.ms/new-console-template for more information

using DesignPatterns.StrategyPattern;

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