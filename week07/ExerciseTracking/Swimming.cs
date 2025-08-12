public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance() => 
        (_laps * LapLengthMeters) * MetersToMiles;
    
    public override double GetSpeed() => 
        (GetDistance() / Length) * 60;
    
    public override double GetPace() => 
        Length / GetDistance();
}