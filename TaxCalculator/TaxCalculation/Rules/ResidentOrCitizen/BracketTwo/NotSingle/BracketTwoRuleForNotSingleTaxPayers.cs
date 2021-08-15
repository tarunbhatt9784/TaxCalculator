using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules.ResidentOrCitizen.Bracket2Rules.NotSingle
{
    public class BracketTwoRuleForNotSingleTaxPayers : ITaxCalculatorRule
    {
        public TaxPayer Evaluate(TaxPayer taxPayer)
        {
            if (taxPayer.GrossIncome > 90000)
            {
                taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.15 * (taxPayer.GrossIncome-90000));
            }
            return taxPayer;
        }

        public bool ShouldRun(TaxPayer taxPayer)
        {
            return taxPayer.IsResidentOrCitizen ? !taxPayer.IsSingle : false;
        }
    }
}
