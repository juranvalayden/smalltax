namespace SmallTax.Data.Entities
{
    public class TaxBracket
    {
        public int Id { get; set; }
        public decimal Rate { get; set; }
        public decimal Lower { get; set; }
        public decimal Upper { get; set; }
    }
}
