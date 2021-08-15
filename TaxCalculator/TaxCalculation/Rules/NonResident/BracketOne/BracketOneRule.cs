using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules.NonResident.BracketOne
{
    public class BracketOneRule : ITaxCalculatorRule
    {
        public TaxPayer Evaluate(TaxPayer taxPayer)
        {
               if (taxPayer.GrossIncome < 30000) taxPayer.TaxedAmount = 0;
            else
            {
                taxPayer.TaxedAmount = taxPayer.TaxedAmount + ((taxPayer.GrossIncome-30000) * .1);
            }
            return taxPayer;
        }

        public bool ShouldRun(TaxPayer taxPayer)
        {
            return !taxPayer.IsResidentOrCitizen;
        }
    }
}
