using Sana05.Classes;


namespace Sana05;

class Program
{
    static void Main(string[] args)
    {
        Airplane flight1 = new Airplane("Kyiv", new MyDate(2025, Month.March, 10, 15, 15), "Warsaw", new MyDate(2025, Month.March, 11, 20, 15));
        
        Airplane flight2 = new Airplane(flight1);
        
        flight2.StartCity = "London";
        flight2.FinishCity = "Paris";
        flight2.StartDate = new MyDate(2025, Month.March, 12, 15, 15);
        flight2.FinishDate = new MyDate(2025, Month.March, 13, 15, 15);
        Console.WriteLine(
            $"flight 2: {flight2.StartCity} - {flight2.FinishCity}\n" + 
            $"Depature: {flight2.StartDate.Year}-{flight2.StartDate.Month}-{flight2.StartDate.Day} {flight2.StartDate.Hours}:{flight2.StartDate.Minutes}\n" +
            $"Arrival: {flight2.FinishDate.Year}-{flight2.FinishDate.Month}-{flight2.FinishDate.Day} {flight2.FinishDate.Hours}:{flight2.FinishDate.Minutes}");
        
        Console.WriteLine($"Total time in minutes: {flight1.GetTotalTime()}");
        flight1.IsArrivingToday();
    }
}