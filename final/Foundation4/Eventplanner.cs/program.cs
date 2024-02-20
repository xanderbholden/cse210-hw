class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "12345");
        Lecture lectureEvent = new Lecture("Lecture Title", "Interesting Lecture", "2024-03-01", "18:00", address1, "John Doe", 50);

        Address address2 = new Address("456 Park Ave", "Townsville", "Stateville", "67890");
        Reception receptionEvent = new Reception("Reception Title", "Social Gathering", "2024-03-05", "19:30", address2, "rsvp@example.com");

        Address address3 = new Address("789 Nature Ln", "Villageland", "Stateville", "54321");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Event", "Enjoy Nature", "2024-03-10", "15:00", address3);

        Event[] events = { lectureEvent, receptionEvent, outdoorEvent };

        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n" + new string('=', 50) + "\n");
        }
    }
}