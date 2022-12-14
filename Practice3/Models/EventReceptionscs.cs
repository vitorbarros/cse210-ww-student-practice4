using System;

namespace Practice3.Models
{
    public class EventReceptions : Event
    {
        private string _email = "";

        public EventReceptions(string title, string description, DateTime date, Address address, string email) : base()
        {
            _email = email;

            _title = title;
            _description = description;
            _dateTime = date;
            _eventType = EventType.Receptions;
            _address = address;
        }

        public string GetFullDetails()
        {
            var fullDesc = base.GetFullDetails();
            return $"{fullDesc} Email: {_email}";
        }
    }
}