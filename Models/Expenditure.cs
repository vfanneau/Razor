namespace Razor.Models
{
    public class Expenditure
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Expenditure(string Name, DateTime Date, double Price)
        {
            this.Name = Name;
            this.Date = Date;
            this.Price = Price;
        }
    }
}
