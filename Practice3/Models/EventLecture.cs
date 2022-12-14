using System;

namespace Practice3.Models
{
    public class EventLecture : Event
    {
        private Speaker _speaker = new Speaker();
        private int _capacity = 0;
        
        public EventLecture(string title, string description, DateTime date, Address address, Speaker speaker, int capacity) : base()
        {
            _speaker = speaker;
            _capacity = capacity;

            _title = title;
            _description = description;
            _dateTime = date;
            _eventType = EventType.Lectures;
            _address = address;
        }

        public string GetFullDetails()
        {
            var fullDesc = base.GetFullDetails();
            return $"{fullDesc} Speaker: {_speaker.ToString()} Capacity: {_capacity}";
        }
    }
}