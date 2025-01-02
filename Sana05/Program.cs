using Sana05.Classes;


namespace Sana05;

class Program
{
    static void Main(string[] args)
    {
        Airplane flight1 = new Airplane("Kyiv", new MyDate(2025, "March", 10, 15, 15), "Warsaw", new MyDate(2025, "March", 10, 20, 15));
        Console.WriteLine(flight1.GetTotalTime());
        flight1.IsArrivingToday();
    }
}