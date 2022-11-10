using System;

namespace MiniMarket.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public double Price { get; set; }
        public string Description { get; set; } = String.Empty; 

        public Product(int id, string name, double price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

        public Product()
        { 
        
        }
    }
}
