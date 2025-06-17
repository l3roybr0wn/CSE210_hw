using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("04 Nov 2022", 45, 20.0),
            new Swimming("05 Nov 2022", 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
