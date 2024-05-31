namespace RazorPizzeria.Models
{
    public class PizzaOrder
    {
        public int Id { get; set; }     // This file is for If this was used with SQL database with EntityFrameworkCore
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
    }
}
