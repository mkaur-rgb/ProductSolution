public abstract class ProductBase
{
    private decimal _price;

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price 
    {
        get => _price;
        set
        {
            if (value < 0) throw new ArgumentException("Price cannot be negative");
            _price = value;
        }
    }

    public ProductBase(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public abstract string GetDetails(); // Abstraction
}
