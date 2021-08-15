using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation
{
    public interface ITaxRuleEngine
    {
        TaxPayer RunTaxEngine(TaxPayer taxPayer);
    }
}
