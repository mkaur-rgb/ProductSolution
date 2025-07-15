namespace ProductApi.Domain
{
    // Abstract class demonstrating Abstraction
    // It cannot be instantiated directly and enforces derived classes to implement abstract members.
    public abstract class ProductBase
    {
        private decimal _price; // Private field demonstrating Encapsulation

        public int Id { get; set; }
        public string Name { get; set; }

        // Property with logic to encapsulate the _price field (Encapsulation)
        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentException("Price cannot be negative");
                _price = value;
            }
        }

        // Constructor to initialize base properties
        public ProductBase(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Abstract method enforcing polymorphism
        // Derived classes must provide their own implementation (runtime behavior varies)
        public abstract string GetDetails();
    }
}
