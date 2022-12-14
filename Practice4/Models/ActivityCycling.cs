using System;

namespace Practice4.Models
{
    public class ActivityCycling : Activity
    {
        private int _speed = 1;
        
        public ActivityCycling(int speed, DateTime date, int len) : base(date, len)
        {
            _speed = speed;
        }

        public override float GeDistance()
        {
            return _speed / 1000;
        }

        public override float GetSpeed()
        {
            return (GeDistance() / _length) * 60;
        }

        public override float GetPace()
        {
            Console.WriteLine(_length);
            Console.WriteLine(GeDistance());
            return _length / GeDistance();
        }
    }
}