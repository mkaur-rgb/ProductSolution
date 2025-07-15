namespace ProductApi.Domain
{
    // SmartProduct inherits from ProductBase (Inheritance)
    public class SmartProduct : ProductBase
    {
        public string SmartFeature { get; set; }

        // Constructor passes parameters to base constructor using base keyword (Inheritance)
        public SmartProduct(int id, string name, decimal price, string smartFeature)
            : base(id, name, price)
        {
            SmartFeature = smartFeature;
        }

        // Implementation of abstract method (Polymorphism)
        // Different derived classes can override this method with their own behavior
        public override string GetDetails() =>
            $"[Smart Product] {Name} - ${Price} | Feature: {SmartFeature}";
    }
}
