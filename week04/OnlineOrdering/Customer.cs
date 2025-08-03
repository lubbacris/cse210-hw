public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA() => _address.IsInUSA();
    public string GetShippingInfo() => $"{_name}\n{_address.GetFullAddress()}";
}