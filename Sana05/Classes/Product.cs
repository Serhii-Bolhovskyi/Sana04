namespace Sana05.Classes;

public class Product
{
    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Product name cannot be empty");
            _name = value;
        }
    }

    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            if(value < 0)
                throw new Exception("Price cannot be negative");
            _price = value;
        }
    }
    
    private Currency _currency;
    public Currency Currency
    {
        get => _currency;
        set => _currency = value;
    }
    
    private int _quantity;
    public int Quantity
    {
        get => _quantity;
        set
        {
            if(value < 0)
                throw new Exception("Quantity cannot be negative");
            _quantity = value;
        }
    }

    private string _producer;
    public string Producer
    {
        get => _producer;
        set
        {
            if(string.IsNullOrEmpty(value))
                throw new Exception("Product name cannot be empty");
            _producer = value;
        }
    }
    
    private double _weight;
    public double Weight
    {
        get => _weight;
        set
        {
            if(value < 0)
                throw new Exception("Weight cannot be negative");
            _weight = value;
        }
    }

    public Product(string name, double price, Currency currency, int quantity, string producer, double weight)
    {
        Name = name;
        Price = price;
        Currency = currency;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }

    public Product(string name, double price, int quantity, string producer)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Producer = producer;
    }
    
    // default constr
    public Product()
    {
        Name = "Unknown product name";
        Price = 0.0;
        Currency = new Currency();
        Quantity = 0;
        Producer = "Unknown producer";
        Weight = 0.0;
    }

    // copy constr
    public Product(Product product)
    {
        Name = product.Name;
        Price = product.Price;
        Currency = product.Currency;
        Quantity = product.Quantity;
        Producer = product.Producer;
        Weight = product.Weight;
    }

    public double GetPriceInUAH()
    {
        double priceInUAH = Price * Currency.ExRate;
        return priceInUAH;
    }

    public double GetTotalPriceInUAH()
    {
        return GetPriceInUAH() * Quantity;
    }

    public double GetTotalWeight()
    {
        return Weight * Quantity;
    }
}