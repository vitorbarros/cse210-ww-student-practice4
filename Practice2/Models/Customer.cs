namespace Practice2.Models
{
    public class Customer
    {
        private readonly string _name;
        private readonly Address _address;

        public Customer()
        {
        }
        
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }
        
        public Address GetAddress()
        {
            return _address;
        }
    }
}