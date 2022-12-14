using System;

namespace Practice4.Models
{
    public class ActivityRunning : Activity
    {
        private int _distance = 0;
        
        public ActivityRunning(int distance, DateTime date, int len) : base(date, len)
        {
            _distance = distance;
        }

        public override float GeDistance()
        {
            return _distance;
        }

        public override float GetSpeed()
        {
            return (_distance / _length) * 60;
        }

        public override float GetPace()
        {
            return _length / GeDistance();
        }
    }
}