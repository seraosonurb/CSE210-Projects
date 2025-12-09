List<Activity> activities = new List<Activity>();

Running running = new Running("03 Nov 2025", 30, 3);
Cycling cycling = new Cycling("30 Mar 2025", 40, 20);
Swimming swimming = new Swimming("24 Nov 2025", 20, 40);
activities.Add(running);
activities.Add(cycling);
activities.Add(swimming);
foreach (Activity activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}
