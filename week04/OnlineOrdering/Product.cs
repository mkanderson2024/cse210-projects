using System;

public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;
    private int _cost;
    public Product(string productName, int productId, int productPrice, int productQuantity)
    {
        _name = productName;
        _id = productId;
        _price = productPrice;
        _quantity = productQuantity;
        _cost = productPrice;
    }
    public int CalculateCost()
    {
        _cost = _quantity * _price;
        return _cost;
    }
    public string GiveProductName()
    {
        string productName = _name;
        return productName;
    }
    public int GiveQuantity()
    {
        int quantity = _quantity;
        return quantity;
    }
}