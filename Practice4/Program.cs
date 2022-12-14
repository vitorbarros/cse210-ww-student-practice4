using System;
using System.Collections.Generic;
using System.Diagnostics;
using Practice4.Models;
using Activity = Practice4.Models.Activity;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            var activityCycling = new ActivityCycling(10, DateTime.Now, 100);
            var activityRunning = new ActivityRunning(100, DateTime.Now, 120);
            var activitySwimming = new ActivitySwimming(50, DateTime.Now, 180);
            
            List<Activity> list = new List<Activity>();
            
            list.Add(activityCycling);
            list.Add(activityRunning);
            list.Add(activitySwimming);

            foreach (var activity in list)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
