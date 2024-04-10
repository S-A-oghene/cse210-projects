using System;
using System.Linq;

class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public decimal TotalCost()
    {
        return Products.Sum(p => p.TotalCost()) + (Customer.IsInUSA() ? 5m : 35m);
    }

    public string PackingLabel()
    {
        return string.Join("\n", Products.Select(p => $"{p.Name} (Product ID: {p.ProductId})"));
    }

    public string ShippingLabel()
    {
        return Customer.Address.GetFullAddress();
    }
}
