using System.Collections.Generic;

namespace Practice2.Models
{
    public class Order
    {
        private int _totalCost = 0;
        private int _shippingCost = 0;
        private string _packingLabel = "";
        private string _shippingLabel = "";
        private readonly List<Product> _products = new List<Product>();
        private readonly Customer _customer = new Customer();

        public Order(List<Product> products, Customer customer)
        {
            _products = products;
            _customer = customer;
            _packingLabel = GetPackingLabel();
            _shippingLabel = GetShippingLabel();
        }

        public int GetTotalCost()
        {
            var total = GetShippingCost();
            foreach (var product in _products)
            {
                total += product.GetQuantity() * product.GetPrice();
            }
            _totalCost = total;
            return _totalCost;
        }
        
        public int GetShippingCost()
        {
            _shippingCost = _customer.GetAddress().isUSA() ? 5 : 35;
            return _shippingCost;
        }
        
        public string GetShippingLabel()
        {
            _shippingLabel = _customer.GetName() + " " + _customer.GetAddress().GetAddress();
            return _shippingLabel;
        }
        
        public string GetPackingLabel()
        {
            _products.Sort((p1, p2 ) => p2.GetId() - p1.GetId());
            foreach (var product in _products)
            {
                _packingLabel += product.GetId() + " " + product.GetName() + " \n";
            }
            
            return _packingLabel;
        }
        
        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}