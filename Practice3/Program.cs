using System;
using System.Collections.Generic;
using Practice3.Models;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address("1310 NE 140th ST North Miami", "USA");
            var weather = new Weather("25", "Sunny");
            var speaker = new Speaker("John");
            
            var eventOutdoor = new EventOutdoor("outdoor event", "the outdoor event", DateTime.Now, address, weather);
            var eventReception = new EventReceptions("reception event", "the reception event", DateTime.Now, address, "vitor@byu.com");
            var eventLecture = new EventLecture("lecture event", "the lecture event", DateTime.Now, address, speaker, 100);

            List<Event> events = new List<Event>();
            
            events.Add(eventOutdoor);
            events.Add(eventReception);
            events.Add(eventLecture);

            foreach (var e in events)
            {
                Console.WriteLine(e.ShortDescription());
                Console.WriteLine(e.GetStandardDetails());
                Console.WriteLine(e.GetFullDetails());
            }
        }
    }
}
