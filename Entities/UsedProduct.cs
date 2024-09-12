

namespace Exercicioaula142.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate {  get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            this.ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $" (used) $ {Price:F2} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
        }
    }
}
