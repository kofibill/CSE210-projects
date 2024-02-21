public abstract class Activity
{
    protected int _length;
    protected string _date;

    public Activity(int length, string date)
    {
        _length = length;
        _date = date;
    }

    public abstract double CalDistance();

    public abstract double CalSpeed();

    public abstract double CalPace();

    public string GetSummary()
    {
        string distance = $"Distance: {CalDistance().ToString("0.0")} km";
        string speed = $"Speed: {CalSpeed().ToString("0.0")} kph";
        string pace = $"Pace: {CalPace().ToString("0.0")} min per km";

        return $"{_date} {GetType().Name} ({_length} min) - {distance}, {speed}, {pace}";
    }
}