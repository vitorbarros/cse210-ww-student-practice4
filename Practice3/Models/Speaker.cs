namespace Practice3.Models
{
    public class Speaker
    {
        private string _name = "";

        public Speaker()
        {
        }
        
        public Speaker(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"{_name}";
        }
    }
}