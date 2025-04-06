public class StationaryBike : Activity
{

    public StationaryBike(string date, double lengthInMinutes, double speed)
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