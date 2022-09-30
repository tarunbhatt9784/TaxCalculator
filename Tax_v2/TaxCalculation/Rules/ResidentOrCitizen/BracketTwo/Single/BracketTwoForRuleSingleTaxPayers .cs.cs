using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules.ResidentOrCitizen.Bracket2Rules.Single
{
    public class BracketTwoRuleForSingleTaxPayers:ITaxCalculatorRule
    {
        public TaxPayer Evaluate(TaxPayer taxPayer)
        {
            if (taxPayer.GrossIncome > 120000)
            {
                taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.2 * (taxPayer.GrossIncome-120000));
            }
            return taxPayer;
        }

        public bool ShouldRun(TaxPayer taxPayer)
        {
            return taxPayer.IsResidentOrCitizen ? taxPayer.IsSingle : false;
        }
    }
}
