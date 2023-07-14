public class Running : Activity
{
    private double _distance;

    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}