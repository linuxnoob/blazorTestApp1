using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace BlazingPizza
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class Order
    {
        public int OrderId { get; set; }

        public required string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
