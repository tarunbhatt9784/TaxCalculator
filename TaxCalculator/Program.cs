using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            TaxPayer taxPayer = new TaxPayer();
            taxPayer.IsResidentOrCitizen = true;
            taxPayer.GrossIncome = 300000;
            taxPayer.IsSingle = true;
            taxPayer.HealthInsuranceAnnualPremium = 3000;
            taxPayer.HasHealthInsurance = true;
            TaxCalculatorRuleEngine taxCalculatorService = new TaxCalculatorRuleEngine();
            taxCalculatorService.ProcessTaxReturn(taxPayer);
        }
    }
}
