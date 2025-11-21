using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    
    public int GetShippingCost()
    {
        int shippingCost = 5;
        if (_customer.InUSA() == false)
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public string DisplayShippingCost()
    {
        return $"Shipping cost: ${GetShippingCost()}";
    }
    public string GetTotalCost()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total += (float)product.GetProductTotalCost();
        }
        total += GetShippingCost();

        return $"Total cost: ${total}";
    }
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach(Product p in _products)
        {
            sb.AppendLine(p.GetName() +", ID: " + p.GetID());
        }
        return "Packing:\n" + sb.ToString();
    }
    public string GetShippingLabel()
    {
        return "To:\n" + _customer.GetName() + " ,Address:\n" + _customer.GetAddress();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void DisplayAllProducts()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetName() + ", ID:" + product.GetID());
        }
    }

}