using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class TaxPayer
    {
        public double GrossIncome { get; set; }
        public bool IsSingle { get; set; }
        public bool IsResidentOrCitizen { get; set; }
        public bool HasHealthInsurance { get; set; }
        public bool HasBusiness { get; set; }
        public bool AtLossInBusiness { get; set; }
        public double TaxedAmount { get; set; }
        public double HealthInsuranceAnnualPremium { get; set; }
    }
}
