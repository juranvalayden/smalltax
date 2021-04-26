﻿using System.Collections.Generic;
using System.Linq;
using SmallTax.Data.Entities;
using SmallTax.Data.Interfaces;

namespace SmallTax.Data.TaxModels
{
    public class ProgressiveTax : ITax
    {
        private readonly IList<TaxBracket> _allTaxBrackets;

        public ProgressiveTax()
        {
            _allTaxBrackets = GetAllTaxBrackets();
        }

        public decimal Calculate(decimal annualSalary)
        {
            var taxBracket = _allTaxBrackets.FirstOrDefault(t => t.Lower <= annualSalary && t.Upper < annualSalary);
            return CalculateTaxByBracket(taxBracket);
        }

        private decimal CalculateTaxByBracket(TaxBracket taxBracket)
        {
            var previousTaxBracket = _allTaxBrackets.FirstOrDefault(t => t.Id == taxBracket.Id - 1);
            decimal differenceInPercentage;
            decimal extraTax;
            decimal standardBracketTax;

            if (previousTaxBracket == null)
            {
                differenceInPercentage = taxBracket.Rate;
                extraTax = (taxBracket.Upper - taxBracket.Lower) * differenceInPercentage / 100;
                standardBracketTax = taxBracket.Lower;
            }
            else
            {
                differenceInPercentage = taxBracket.Rate - previousTaxBracket.Rate;
                extraTax = (taxBracket.Upper - taxBracket.Lower) * differenceInPercentage / 100;
                standardBracketTax = taxBracket.Lower * previousTaxBracket.Rate / 100;
            }

            return extraTax + standardBracketTax;
        }

        private static List<TaxBracket> GetAllTaxBrackets()
        {
            var taxBrackets = new List<TaxBracket>
            {
                new TaxBracket {Id=1,Rate=10,Lower=1,Upper=8350},
                new TaxBracket {Id=2,Rate=15, Lower= 8351,  Upper=33950},
                new TaxBracket {Id=3,Rate=25, Lower= 33951, Upper=82250},
                new TaxBracket {Id=4,Rate=28, Lower= 82251, Upper=171550},
                new TaxBracket {Id=5,Rate=33, Lower= 171551,Upper= 372950},
                new TaxBracket {Id=6,Rate= 35,Lower=  37951,Upper= -1}
            };

            return taxBrackets;
        }
    }
}