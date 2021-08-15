using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules.NonResident.BracketOne.Single
{
    public class BracketTwoRuleForSingleTaxPayers : ITaxCalculatorRule
    {

        public TaxPayer Evaluate(TaxPayer taxPayer)
        {
            if (taxPayer.GrossIncome > 70000)
            {
                taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.15 * (taxPayer.GrossIncome-70000));
            }
            return taxPayer;
        }

        public bool ShouldRun(TaxPayer taxPayer)
        {
            return taxPayer.IsResidentOrCitizen ? false : taxPayer.IsSingle;
        }
    }
}
