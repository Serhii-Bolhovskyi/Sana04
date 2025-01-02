namespace Sana05.Classes;

public class MyDate
{
    protected int Year;
    protected string Month;
    protected int Day;
    protected int Hours;
    protected int Minutes;

    public MyDate(int year, string month, int day, int hours, int minutes)
    {
        SetYear(year);
        SetMonth(month);
        SetDay(day);
        SetHours(hours);
        SetMinutes(minutes);
    }

    public void SetYear(int year)
    {
        if (year >= 1 && year <= DateTime.Now.Year)
        {
            Year = year;
        }
        else
        {
            throw new Exception("Invalid year"); 
        }
    }

    public void SetMonth(string month)
    {
        if (string.IsNullOrEmpty(month))
            throw new Exception("Invalid month");
        Month = month;
    }

    public void SetDay(int day)
    {
        if (day >= 1 && day <= 31) // Static range check
        {
            Day = day;
        }
        else
        {
            throw new Exception("Invalid day. Day must be between 1 and 31.");
        }
    }

    public void SetHours(int hours)
    {
        if(hours >= 0 && hours <= 23)
            Hours = hours;
        else
            throw new Exception("Invalid hours");
    }

    public void SetMinutes(int minutes)
    {
        if(minutes >= 0 && minutes <= 59)
            Minutes = minutes;
        else 
            throw new Exception("Invalid minutes");
    }
    
    public DateTime ToDateTime()
    {
        int monthNumber = Array.IndexOf(new string[] { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" },
            Month) + 1;

        if (monthNumber == 0)
        {
            throw new Exception("Invalid month name.");
        }

        return new DateTime(Year, monthNumber, Day, Hours, Minutes, 0);
    }

    public int GetDay()
    {
        return Day;
    }
    
}