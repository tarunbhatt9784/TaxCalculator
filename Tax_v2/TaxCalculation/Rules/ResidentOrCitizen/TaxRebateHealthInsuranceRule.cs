using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules.ResidentOrCitizen
{
    public class TaxRebateHealthInsuranceRule : ITaxCalculatorRule
    {
        public TaxPayer Evaluate(TaxPayer taxPayer)
        {
            if (taxPayer.HasHealthInsurance)
            {
                taxPayer.TaxedAmount = taxPayer.TaxedAmount - (taxPayer.HealthInsuranceAnnualPremium * .1);
            }
            return taxPayer;
        }

        public bool ShouldRun(TaxPayer taxPayer)
        {
            return taxPayer.HasHealthInsurance && taxPayer.IsResidentOrCitizen;
        }
    }
}
