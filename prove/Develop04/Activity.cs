using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public class Activity
{
    public static void ActivityStart(string activityChoice)
    {
        if (activityChoice == "1")
        {
            BreathingActivity.Start();
        }
        else if (activityChoice == "2")
        {
            ListingActivity.Start();
        }
        else if (activityChoice == "3")
        {
            ReflectingActivity.Start();
        }

    }
    public static void Welcome(string activityChoice)
    {
        string _activityName = "";
        if (activityChoice == "1")
        {
            _activityName = "Breathing";
        }
        else if (activityChoice == "2")
        {
            _activityName = "Listing";
        }
        else if (activityChoice == "3")
        {
            _activityName = "Reflecting";
        }
        Console.WriteLine($"Welcome to the {_activityName} Activity!");
        ActivityStart(activityChoice);
    }


    public static void Goodbye(string activityChoice)
    {
        string _activityName = "";
        if (activityChoice == "1")
        {
            _activityName = "Breathing";
        }
        else if (activityChoice == "2")
        {
            _activityName = "Listing";
        }
        else if (activityChoice == "3")
        {
            _activityName = "Reflecting";
        }
        Console.WriteLine($"Thanks for doing the {_activityName} Activity! Would you like to try another?");
    }
}
