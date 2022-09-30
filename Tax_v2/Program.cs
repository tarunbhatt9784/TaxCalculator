using System;
using System.Collections.Generic;
using System.Text;
using TaxCalculator.TaxCalculation;

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
            TaxCalculatorService taxCalculatorService = new TaxCalculatorService();
            taxPayer = taxCalculatorService.ProcessTaxReturn(taxPayer);
            Console.WriteLine("tax amount ="+taxPayer.TaxedAmount);
        }
    }
}
