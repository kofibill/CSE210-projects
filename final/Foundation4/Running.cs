public class Running : Activity
{
    private double _distance;

    public Running(double distance, int length, string date) : base(length, date)
    {
        _distance = distance;
    }

    public override double CalSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double CalDistance()
    {
        return _distance;

    }

    public override double CalPace()
    {
        return _length / _distance;
    }
}