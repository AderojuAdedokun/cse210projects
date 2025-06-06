using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<string> activityLog = new List<string>(); // Extra feature: activity log

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            string activityName = "";

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activityName = "Breathing Activity";
                    break;
                case "2":
                    activity = new ListingActivity();
                    activityName = "Listing Activity";
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    activityName = "Reflecting Activity";
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            if (activity != null)
            {
                activity.Run();
                activityLog.Add($"{DateTime.Now}: {activityName} for {activity._duration} seconds");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
        }

        // Show the activity log when quitting
        Console.WriteLine("\nActivity Log:");
        foreach (string log in activityLog)
        {
            Console.WriteLine(log);
        }
        Console.WriteLine("Goodbye!");
    }
}