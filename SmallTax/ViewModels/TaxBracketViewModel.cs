namespace SmallTax.ViewModels
{
    public class TaxBracketViewModel
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public decimal Lower { get; set; }
        public decimal Upper { get; set; }
    }
}