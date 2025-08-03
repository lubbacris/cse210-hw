public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) => _customer = customer;

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotal()
    {
        double total = _products.Sum(p => p.GetTotalCost());
        return total + (_customer.IsInUSA() ? 5 : 35);
    }

    public string GetPackingLabel()
    {
        return "PACKING LABEL:\n" + 
               string.Join("\n", _products.Select(p => p.GetPackingInfo()));
    }

    public string GetShippingLabel() => 
        "SHIPPING LABEL:\n" + _customer.GetShippingInfo();
}