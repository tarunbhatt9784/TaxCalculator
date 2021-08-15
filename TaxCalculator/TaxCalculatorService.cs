using System;
using System.Collections.Generic;
using System.Linq;
using TaxCalculator.TaxCalculation;
using TaxCalculator.TaxCalculation.Rules;

namespace TaxCalculator
{
    class TaxCalculatorService
    {
        public TaxPayer ProcessTaxReturn(TaxPayer taxPayer)
        {
            var ruleType = typeof(ITaxCalculatorRule);
            IEnumerable<ITaxCalculatorRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ITaxCalculatorRule);
            var engine = new TaxCalculatorRuleEngine(rules);
            return engine.CalculateTax(taxPayer);
        }
    }
}
