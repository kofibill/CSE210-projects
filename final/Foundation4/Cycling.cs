public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, int length, string date) : base(length, date)
    {
        _speed = speed;
    }

    public override double CalDistance()
    {
        double time = (_length / 60.0); //Convert mins to hrs
        double distance = _speed * time;

        return distance;
    }

    public override double CalSpeed()
    {
        return _speed;
    }

    public override double CalPace()
    {
        return 60 / _speed;
    }
}