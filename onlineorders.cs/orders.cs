class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
