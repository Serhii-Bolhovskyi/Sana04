using Sana05.Classes;


namespace Sana05;

class Program
{
    static void Main(string[] args)
    {
        Airplane flight1 = new Airplane("Kyiv", new MyDate(2025, Month.March, 11, 15, 15), "Warsaw", new MyDate(2025, Month.March, 11, 20, 15));
        
        Airplane flight2 = new Airplane(flight1);
        Airplane flight3 = new Airplane();
        Airplane flight4 = new Airplane("Lviv", "Liverpool");
        
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
        
        Product Sony = new Product("Camera", 40.00, new Currency("USD", 42.07),5, "Sony", 2.50);

        Product Laptop = new Product();
        Product Smartphone = new Product("Samsung A-52", 300.00, 1, "Samsung");

        Product Sony1 = new Product(Sony);
        Sony1.Price = 100.00;
        Sony1.Quantity = 2;
        Sony1.Weight = 1.00;
        
        Console.WriteLine($"Price in UAH {Sony1.GetPriceInUAH()}");
        
        Console.WriteLine(Sony.GetPriceInUAH());
        Console.WriteLine(Sony.GetTotalPriceInUAH());
        Console.WriteLine(Sony.GetTotalWeight());
        
        
        Console.WriteLine($"{Sony.Name}, {Sony.Price}, {Sony.Currency.Name} - {Sony.Currency.ExRate}, {Sony.Quantity}, {Sony.Producer}, {Sony.Weight}");
        
        
    }
}