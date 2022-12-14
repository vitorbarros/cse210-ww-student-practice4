using System;

namespace Practice4.Models
{
    public abstract class Activity
    {
        protected DateTime _date = DateTime.Now;
        protected int _length = 1;
        
        protected Activity(DateTime date, int length)
        {
            _date = date;
            _length = length;
        }

        public abstract float GeDistance();
        public abstract float GetSpeed();
        public abstract float GetPace();

        public string GetSummary()
        {
            return $"Date: {_date.ToString("M/d/yy - HH:mm:ss")}, Distance: {GeDistance()}km Speed: {GetSpeed()}km/h, Pace: {GetPace()}min/km";
        }
    }
}