using System;

namespace SmallTax.Data.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        string PostalCode { get; set; }
        decimal AnnualSalary { get; set; }
        DateTime CreatedDate { get; set; }

        decimal TotalTax();
    }
}