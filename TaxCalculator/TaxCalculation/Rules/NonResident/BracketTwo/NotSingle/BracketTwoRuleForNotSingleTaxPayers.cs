using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules.NonResident.BracketTwo.NotSingle
{
    public class BracketTwoRuleForNotSingleTaxPayers : ITaxCalculatorRule
    {
        public TaxPayer Evaluate(TaxPayer taxPayer)
        {
            if (taxPayer.GrossIncome > 100000)
            {
                taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.2 * (taxPayer.GrossIncome)-100000);
            }
            return taxPayer;
        }

        public bool ShouldRun(TaxPayer taxPayer)
        {
            return taxPayer.IsResidentOrCitizen ? false : !taxPayer.IsSingle;
        }
    }
}
