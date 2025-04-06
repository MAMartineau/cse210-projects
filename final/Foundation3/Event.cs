
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date/Time: {_date} at " +
               $"{_time}\n" +
               $"Location:\n{_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"({GetType().Name}) {_title} - {_date}";
    }
}