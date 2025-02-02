using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int CaculateCost()
    {
        int subTotal = 0;
        int total;
        foreach (var product in _products)
        {
            subTotal += product.CalculateCost();
        }
        bool country = _customer.IsInUsa();
        if (country == true)
        {
            total = subTotal + 5;
        }
        else
            total = subTotal + 15;
        return total;
    }
    public string ProducePackingLabel()
    {
        List<string> packingItems = new List<string>();
        string packingItem;
        string packingLabel;
        string converted;
        foreach (var product in _products)
        {
            packingItem = $"{product.GiveProductName()} - {product.GiveQuantity()}";
            packingItems.Add(packingItem);
        }
        converted = String.Join(" | ", packingItems);
        packingLabel = converted;
        return packingLabel;
    }
    public string ProduceShippingLabel()
    {
        string customerAddress;
        customerAddress = $"{_customer.GetName()}\n{_customer.GetAddress()}";
        return customerAddress;
    }
}



//
