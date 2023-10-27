namespace task1_RazorP_.Models
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = null!;
    }
}
