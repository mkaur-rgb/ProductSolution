public class SmartProduct : ProductBase
{
    public string SmartFeature { get; set; }

    public SmartProduct(int id, string name, decimal price, string smartFeature)
        : base(id, name, price)
    {
        SmartFeature = smartFeature;
    }

    public override string GetDetails() =>
        $"[Smart Product] {Name} - ${Price} | Feature: {SmartFeature}";
}
