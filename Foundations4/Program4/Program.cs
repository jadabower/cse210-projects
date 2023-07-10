List<Activity> activities = new List<Activity>();
Cycling cycling = new Cycling("07 July 2023", 20, 10.0);
activities.Add(cycling);
Running running = new Running("04 May 2023", 45, 8.5);
activities.Add(running);
Swimming swimming = new Swimming("23 November 2022", 30, 5);
activities.Add(swimming);

foreach(Activity activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}