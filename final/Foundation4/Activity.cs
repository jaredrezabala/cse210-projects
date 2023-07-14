public class Activity
{
    private DateTime _date;
    protected double _length;

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        string summary = $"Date: {_date.ToShortDateString()}\n";
        summary += $"Activity Type: {GetType().Name}\n";
        summary += $"Length: {_length} minutes\n";
        summary += $"Distance: {GetDistance()} miles\n";
        summary += $"Speed: {GetSpeed()} mph\n";
        summary += $"Pace: {GetPace()} mins/mile\n";
        return summary;
    }
}