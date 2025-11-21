public class Product
{
    private string _name;
    private string _productID;
    private float _pricePerUnity;
    private int _productQuantity;
    public float GetProductTotalCost()
    {
       float total = (float)_pricePerUnity * (float)_productQuantity;
       return total;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
    public Product(string name, string id, float unitPrice, int quantity)
    {
        _name = name;
        _productID = id;
        _pricePerUnity = unitPrice;
        _productQuantity = quantity;
    }
}