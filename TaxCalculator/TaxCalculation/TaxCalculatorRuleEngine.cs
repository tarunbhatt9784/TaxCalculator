using System.Collections.Generic;
using TaxCalculator.TaxCalculation.Rules;

namespace TaxCalculator.TaxCalculation
{
    public class TaxCalculatorRuleEngine
    {
        private readonly IEnumerable<ITaxCalculatorRule> _rules;
        public TaxCalculatorRuleEngine(IEnumerable<ITaxCalculatorRule> rules)
        {
            _rules = rules;
        }
        public TaxPayer CalculateTax(TaxPayer taxPayer)
        {

            foreach(var rule in _rules)
            {
                if (rule.ShouldRun(taxPayer)) taxPayer =  rule.Evaluate(taxPayer);
            }
            return taxPayer;
        }
    }
}
