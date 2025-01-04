namespace Sana05.Classes;

public class Currency
{
    private string _name; 
    public string Name
    {
        get => _name;
        set
        {
            if(string.IsNullOrEmpty(value))
                throw new Exception("Name cannot be empty");
            _name = value;
        }
    }

    private double _exRate; 
    public double ExRate
    {
        get => _exRate;
        set
        {
            if(value < 0)
                throw new Exception("ExRate cannot be negative");
            _exRate = value;
        }
    }

    public Currency(string name, double exRate)
    {
        Name = name;
        ExRate = exRate;
    }

    public Currency(string name)
    {
        Name = name;
    }

    public Currency()
    {
        Name = "Unknown";
        ExRate = 0.0;
    }

    public Currency(Currency currency)
    {
        Name = currency.Name;
        ExRate = currency.ExRate;
    }
}