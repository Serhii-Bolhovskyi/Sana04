namespace Sana05.Classes;

public class MyDate
{
    private int _year;
    public int Year
    {
        get => _year;
        set
        {
            if (value >= 1 && value <= DateTime.Now.Year)
            {
                _year = value;
            }
            else
            {
                throw new Exception("Invalid year"); 
            }
        } 
    }
    
    private Month _month;
    public Month Month
    {
        get => _month;
        set => _month = value;
    }
    
    private int _day;
    public int Day
    {
        get => _day;
        set
        {
            if (value <= 1 && value >= 31)
                throw new Exception("Invalid day. Day must be between 1 and 31.");
            _day = value;
        }
    }
    
    private int _hours;
    public int Hours
    {
        get => _hours;
        set
        {
            if(value >= 0 && value <= 23)
                _hours = value;
            else
                throw new Exception("Invalid hours");
        }
    }
    
    private int _minutes;
    public int Minutes
    {
        get => _minutes;
        set
        {
            if(value >= 0 && value <= 59)
                _minutes = value;
            else 
                throw new Exception("Invalid minutes");
        }
    }

    public MyDate(int year, Month month, int day, int hours, int minutes)
    {
        Year = year;
        Month = month;
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }
    
    public MyDate(MyDate copMyDate)
    {
        Year = copMyDate.Year;
        Month = copMyDate.Month;
        Day = copMyDate.Day;
        Hours = copMyDate.Hours;
        Minutes = copMyDate.Minutes;
    }
    
    public MyDate()
    {
        Year = 1;
        Month = Month.Unknown;
        Day = 1;
        Hours = 0;
        Minutes = 0;
    }

    public MyDate(Month month, int day)
    {
        Month = month;
        Day = day;
    }
    
    public DateTime ToDateTime()
    {
        return new DateTime(Year, (int)Month, Day, Hours, Minutes, 0);
    }

   
    
}