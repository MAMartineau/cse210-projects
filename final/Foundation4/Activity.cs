
public class Activity
{
    private string _date;
    private double _lengthInMinutes;

    public Activity(string date, double lengthInMinutes)
    {
        
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}