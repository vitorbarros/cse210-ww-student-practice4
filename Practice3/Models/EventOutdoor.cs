using System;

namespace Practice3.Models
{
    public class EventOutdoor : Event
    {
        private Weather _weather = new Weather();

        public EventOutdoor(string title, string description, DateTime date, Address address, Weather weather)
        {
            _weather = weather;
            
            _title = title;
            _description = description;
            _dateTime = date;
            _eventType = EventType.Outdoor;
            _address = address;
        }
        
        public string GetFullDetails()
        {
            var fullDesc = base.GetFullDetails();
            return $"{fullDesc} Weather: {_weather.ToString()}";
        }
    }
}