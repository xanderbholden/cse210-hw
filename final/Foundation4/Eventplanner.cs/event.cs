public class Event
{
    public string Title { get; }
    public string Description { get; }
    public string Date { get; }
    public string Time { get; }
    public Address Address { get; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address.Street}, {Address.City}, {Address.State} {Address.ZipCode}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}";
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }
}