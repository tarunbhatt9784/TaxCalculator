using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.TaxCalculation
{
    public class TaxRuleCalculationEasy
    {
        public TaxPayer CalculateTaxWithoutRuleEngineDesignPatern(TaxPayer taxPayer)
        {
            if (taxPayer.IsResidentOrCitizen)
            {
                if (taxPayer.GrossIncome < 40000) taxPayer.TaxedAmount = 0;
                else
                {
                    taxPayer.TaxedAmount = taxPayer.TaxedAmount + ((taxPayer.GrossIncome-40000)* .1);
                    if (taxPayer.IsSingle)
                    {
                        if (taxPayer.GrossIncome > 90000)
                        {
                            taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.15 * (90000 - taxPayer.GrossIncome));
                        }
                    }
                    else
                    {
                        if (taxPayer.GrossIncome > 120000)
                        {
                            taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.2 * (120000 - taxPayer.GrossIncome));
                        }
                    }
                    if (taxPayer.HasHealthInsurance)
                    {
                        taxPayer.TaxedAmount = taxPayer.TaxedAmount - (taxPayer.HealthInsuranceAnnualPremium * .1);
                    }
                }
            }
            else
            {
                if (taxPayer.GrossIncome < 30000) taxPayer.TaxedAmount = 0;
                else
                {
                    taxPayer.TaxedAmount = taxPayer.TaxedAmount + ((taxPayer.GrossIncome - 30000) * .1);
                    if (taxPayer.IsSingle)
                    {
                        if (taxPayer.GrossIncome > 70000)
                        {
                            taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.15 * (taxPayer.GrossIncome-70));
                        }
                    }
                    else
                    {
                        if (taxPayer.GrossIncome > 100000)
                        {
                            taxPayer.TaxedAmount = taxPayer.TaxedAmount + (.2 * (taxPayer.GrossIncome-100000));
                        }
                    }
                }
            }
            return taxPayer;
        }

    }
}
