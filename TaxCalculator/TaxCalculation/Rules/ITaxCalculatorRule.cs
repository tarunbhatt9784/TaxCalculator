using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation.Rules
{
    public interface ITaxCalculatorRule
    {
        //bool ShouldRun(TaxPayer taxPayer);
        TaxPayer Evaluate(TaxPayer taxPayer);
        bool ShouldRun(TaxPayer taxPayer);
    }
}
