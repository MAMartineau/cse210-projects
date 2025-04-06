
public class Swimming : Activity
{

    public Swimming(string date, double lengthInMinutes, int laps)
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