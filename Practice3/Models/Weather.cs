namespace Practice3.Models
{
    public class Weather
    {
        private string _temperature = "";
        private string _description = "";

        public Weather()
        {
        }
        
        public Weather(string temperature, string description)
        {
            _temperature = temperature;
            _description = description;
        }

        public override string ToString()
        {
            return $"{_temperature}, {_description}";
        }
    }
}