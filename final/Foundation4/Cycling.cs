public class Cycling : Activity
{
    private double _distance;
    private double _speed;

    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}