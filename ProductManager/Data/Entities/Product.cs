﻿namespace ProductManager.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
