
public class Running : Activity
{

    public Running(string date, double lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {

    }

    public override double GetDistance()
    {
        return 0.0;
    }

    public override double GetSpeed()
    {
        return 0.0;
    }

    public override double GetPace()
    {
        return 0.0;
    }

    public override string GetSummary()
    {
        return "";
    }
}

