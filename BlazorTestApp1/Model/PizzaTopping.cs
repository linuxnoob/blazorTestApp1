#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace BlazingPizza
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class PizzaTopping
    {
        public required Topping Topping { get; set; }

        public int ToppingId { get; set; }
        
        public int PizzaId { get; set; }
    }
}
