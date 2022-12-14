namespace Practice2.Models
{
    public class Address
    {
        private readonly string _address;
        private readonly string _country;
        
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
        
        public bool isUSA()
        {
            return _country == "USA";
        }
    }
}