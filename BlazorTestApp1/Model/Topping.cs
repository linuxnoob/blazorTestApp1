#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace BlazingPizza
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class Topping
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}
