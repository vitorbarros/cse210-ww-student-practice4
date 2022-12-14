using System;

namespace Practice3.Models
{
    public abstract class Event
    {
        protected string _title = "";
        protected string _description = "";
        protected DateTime _dateTime = DateTime.Now;
        protected EventType _eventType = EventType.None;
        protected Address _address = new Address();

        public string ShortDescription()
        {
            return $"Title: {_title} Date: {_dateTime.ToString("MM/dd/yyyy")} Type: {_eventType.ToString()}";
        }
        
        public string GetStandardDetails()
        {
            return $"Title: {_title} Description: {_description} Date: {_dateTime.ToString("MM/dd/yyyy")} Time: {_dateTime.ToString("hh:mm")} Address: {_address.ToString()}";
        }
        
        public string GetFullDetails()
        {
            return $"{GetStandardDetails()} Type: {_eventType.ToString()}";
        }
    }
}