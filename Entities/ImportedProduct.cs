namespace Exercicioaula142.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price,double customFee)
            :base(name,price)
        {
            CustomFee = customFee;
        }
        public override string PriceTag()
        {
            return $"$ {Price:F2} Custom fee: $ {CustomFee:F2}";
        }
    }
}
