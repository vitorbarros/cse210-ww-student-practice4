namespace Practice3.Models
{
    public class Address
    {
        private readonly string _address;
        private readonly string _country;

        public Address()
        {
        }
        
        public Address(string address, string country)
        {
            _address = address;
            _country = country;
        }
        
        public string GetAddress()
        {
            return _address;
        }
        
        public string GetCountry()
        {
            return _country;
        }

        public override string ToString()
        {
            return $"{_address}, {_country}";
        }
    }
}