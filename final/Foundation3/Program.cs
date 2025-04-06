using System;

public class Program
{
    public static void Main()
    {
        Address add1 = new("10 Redwood Lane", "Maplewood", "IN", "USA");
        Address add2 = new("55 Bloomfield Ave", "Evergreen", "BC", "Canada");
        Address add3 = new("789 Sunrise Blvd", "Oceanview", "FL", "USA");

        Lecture lecture = new(
            "Fundamentals of Stage Sound Effects",
            "An introductory session covering the basics of creating and mixing sound effects on stage",
            "August 1, 2025",
            "9:00 AM",
            add1,
            "Dr. Heather Clarke",
            80
        );

        Reception reception = new(
            "Meet the Sound Crew",
            "An informal gathering where you can talk with professional sound designers",
            "August 1, 2025",
            "4:00 PM",
            add2,
            "rsvp@soundcrewevents.com"
        );

        OutdoorGathering outdoorGathering = new(
            "Open-Air Sound Testing",
            "An outdoor demonstration of how to optimize audio in open-air venues",
            "August 2, 2025",
            "10:30 AM",
            add3,
            "Sunny with a light breeze"
        );

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details");
            Console.WriteLine("----------------");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details");
            Console.WriteLine("------------");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description");
            Console.WriteLine("-----------------");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine();
        }
    }
}