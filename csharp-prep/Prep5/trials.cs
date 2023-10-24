using Systems;

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startDate;
    public int _endDate;

    public void Dispaly()
    {
        Console.WriteLine($"{_jobTitle}{_companyName} {_startDate}-{_endDate}");
    }
    
}
