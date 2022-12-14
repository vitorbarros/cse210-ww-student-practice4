using System;

namespace Practice2.Models
{
    public class Product
    {
        private readonly string _name = "";
        private readonly int _price = 0;
        private readonly int _quantity = 0;
        private int _id;
        
        public Product(string name, int price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }
        
        public string GetName()
        {
            return _name;
        }
        
        public int GetPrice()
        {
            return _price;
        }
        
        public int GetQuantity()
        {
            return _quantity;
        }
        
        public int GetId()
        {
            Random rnd = new Random();

            for (int j = 0; j < 4; j++)
            {
                _id = rnd.Next();
            }
            return _id;
        }
    }
}