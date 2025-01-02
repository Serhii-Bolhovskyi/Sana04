namespace Sana05.Classes;

public class Airplane
{
    protected string StartCity;
    protected string FinishCity;
    protected MyDate StartDate;
    protected MyDate FinishDate;

    public Airplane(string startCity, MyDate startDate, string finishCity, MyDate finishDate)
    {
        SetStartCity(startCity);
        StartDate = startDate;
        
        SetFinishCity(finishCity);
        FinishDate = finishDate;
    }

    public void SetStartCity(string startCity)
    {
        if(string.IsNullOrEmpty(startCity))
            throw new Exception("StartCity cannot be null or empty");
        StartCity = startCity;
    }

    public void SetFinishCity(string finishCity)
    {
        if(string.IsNullOrEmpty(finishCity))
            throw new Exception("StartCity cannot be null or empty");
        FinishCity = finishCity; 
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
        if (StartDate.GetDay() == FinishDate.GetDay())
        {
            Console.WriteLine("Departure and arrival on the same day");
            return true;
        }
        else
        {
            Console.WriteLine("Departure and arrival on differnt same day");
            return false;
        }
    }
}