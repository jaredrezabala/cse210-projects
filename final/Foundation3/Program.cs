using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Event objects
        Event event1 = new Lecture();
        Event event2 = new Reception();
        Event event3 = new OutdoorGathering();

        // Set attributes for event1 (Lecture)
        event1.EventTitle = "Introduction to Programming";
        event1.Description = "Learn the basics of programming";
        event1.Date = new DateTime(2023, 6, 15);
        event1.Time = "10:00 AM";
        event1.Address = new Address()
        {
            StreetAddress = "123 Main Street",
            City = "New York",
            StateProvince = "NY",
            Country = "USA"
        };
        ((Lecture)event1).Speaker = "Jared Rezabala";
        ((Lecture)event1).Capacity = 50;

        // Set attributes for event2 (Reception)
        event2.EventTitle = "Company Anniversary Celebration";
        event2.Description = "Join us to celebrate our company's anniversary";
        event2.Date = new DateTime(2023, 7, 1);
        event2.Time = "7:00 PM";
        event2.Address = new Address()
        {
            StreetAddress = "456 Park Avenue",
            City = "San Francisco",
            StateProvince = "CA",
            Country = "USA"
        };
        ((Reception)event2).RSVPEmail = "celebration@company.com";

        // Set attributes for event3 (Outdoor Gathering)
        event3.EventTitle = "Summer Picnic";
        event3.Description = "Enjoy a fun-filled day at our annual summer picnic";
        event3.Date = new DateTime(2023, 8, 10);
        event3.Time = "12:00 PM";
        event3.Address = new Address()
        {
            StreetAddress = "789 Beach Road",
            City = "Miami",
            StateProvince = "FL",
            Country = "USA"
        };
        ((OutdoorGathering)event3).WeatherForecast = "Sunny";

        // Create a list to store the events
        List<Event> eventList = new List<Event> { event1, event2, event3 };

        // Iterate through the event list and display the details
        foreach (Event evnt in eventList)
        {
            Console.WriteLine("----------");
            Console.WriteLine(evnt.GetFullDetails());
        }
    }
}
