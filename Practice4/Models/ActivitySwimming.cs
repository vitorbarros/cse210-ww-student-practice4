using System;

namespace Practice4.Models
{
    public class ActivitySwimming : Activity
    {
        private int _laps = 0;
        
        public ActivitySwimming(int laps, DateTime date, int len) : base(date, len)
        {
            _laps = laps;
        }
        
        public override float GeDistance()
        {
            return _laps * 50 / 1000;
        }

        public override float GetSpeed()
        {
            return (GeDistance() / _length) * 60;
        }

        public override float GetPace()
        {
            return _length / GeDistance();
        }
    }
}