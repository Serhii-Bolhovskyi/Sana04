namespace Sana05.Classes;

public class Airplane
{
    private string _startCity;
    public string StartCity
    {
        get => _startCity;
        set
        {
            if(string.IsNullOrEmpty(value))
                throw new Exception("StartCity cannot be null or empty");
            _startCity = value;
        }
    }
    
    private string _finishCity;
    public string FinishCity
    {
        get => _finishCity;
        set
        {
            if(string.IsNullOrEmpty(value))
                throw new Exception("FinishCity cannot be null or empty");
            _finishCity = value;
        }
    }
    
    private MyDate _startDate;
    public MyDate StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }
    
    private MyDate _finishDate;
    public MyDate FinishDate
    {
        get => _finishDate;
        set => _finishDate = value;
    }

    public Airplane(string startCity, MyDate startDate, string finishCity, MyDate finishDate)
    {
        StartCity = startCity;
        StartDate = startDate;
        
        FinishCity = finishCity;
        FinishDate = finishDate;
    }

    public Airplane(string startCity, string finishCity)
    {
        StartCity = startCity;
        FinishCity = finishCity;
    }
    
    // copy constructor
    public Airplane(Airplane airplane)
    {
        StartCity = airplane.StartCity;
        StartDate = airplane.StartDate;
        
        FinishCity = airplane.FinishCity;
        FinishDate = airplane.FinishDate;
    }
    
    // default constructor
    public Airplane()
    {
        StartCity = "Unknown";
        StartDate = new MyDate(); // default constructor
        FinishCity = "Unknown";
        FinishDate = new MyDate();
    }
    
    public int GetTotalTime()
    {
        DateTime start = StartDate.ToDateTime();
        DateTime finish = FinishDate.ToDateTime();
        
        TimeSpan diff = finish - start;
        
        return (int)diff.TotalMinutes;
    }

    public bool IsArrivingToday()
    {
        if (StartDate.Day == FinishDate.Day)
        {
            Console.WriteLine("Departure and arrival on the same day");
            return true;
        }
        else
        {
            Console.WriteLine("Departure and arrival on different day");
            return false;
        }
    }
}