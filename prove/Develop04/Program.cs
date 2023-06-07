using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("name", "description");
        activity.DisplayStartMessage();
        activity.SetNewDuration();
        activity.DisplayPauseAnimation();
        activity.DisplayEndMessage();
    }
}