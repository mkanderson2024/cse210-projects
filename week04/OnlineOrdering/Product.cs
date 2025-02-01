using System;

public class Product
{
    private string _name;
    private string _id;
    private int _price;
    private int _quantity;
    private int _cost;

    public int CalculateCost()
    {
        _cost = _quantity * _price;
        return _cost;
    }
}